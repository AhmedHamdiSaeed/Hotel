﻿using Hotel_API.Controllers.Booking;
using Hotel_BL.Dtos.Booking;
using Hotel_DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_DAL.Data.Model;
using Hotel_BL.Dtos.Room;
using Hotel_BL.Services;

namespace Hotel_BL.Managers.Booking
{
    public class BookingManager: IBookingManager
    {
        private IUnitOfWork _unitOfWork;
        public BookingManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public   object? GetAll(QueryParams queryParams)
        {
           var query=  _unitOfWork.BookingRepo.getAllWithCustomerAndBranch();
            if (query == null) 
            {
                return null;
            }
            if (!string.IsNullOrWhiteSpace(queryParams.SearchTerm))
                query=query.Where(b=>b.Customer.Name.Contains(queryParams.SearchTerm)).AsQueryable();
            if (!string.IsNullOrWhiteSpace(queryParams.SortBy))
            {
                if (queryParams.SortBy == "TotalPrice")
                    query = query.OrderBy(o => o.TotalPrice);
                else if (queryParams.SortBy == "Name")
                    query = query.OrderBy(o => o.Customer.Name);
                else if (queryParams.SortBy == "NumOfRooms")
                    query = query.OrderBy(o => o.NumOfRooms);
                else
                    throw new Exception("not found this property");
            }
            //paging
            var Total = query.Count();
            var totalPages=Total/queryParams.PageSize;
            if (totalPages < 1) totalPages = 1;
            var skipAmount=(queryParams.PageNumber-1)*queryParams.PageSize;
            return   new QueryResult(query.Skip(skipAmount).Take(queryParams.PageSize).Select(b => new BookingDto(b.Id, b.Customer.Name, b.Branch.Name, b.NumOfRooms, b.checkInDate, b.checkOutDate, b.TotalPrice)).ToList(),totalPages,queryParams.PageNumber,queryParams.PageSize,Total);
        }
        public async Task<List<int>?> AddBooking(BookingAddDto bookingAddDto)
        {
            var availbleRooms =  _unitOfWork.RoomRepo.GetAvailableRooms(bookingAddDto.BookingDate.checkInDate.ToDateOnly(), bookingAddDto.BookingDate.checkOutDate.ToDateOnly());
            if (availbleRooms == null)
                return new List<int>() { 0};
            var availbleRoomIDs=availbleRooms.Select(r => r.ID);
            var bookingRoomsID = bookingAddDto.Rooms.Select(r => r.roomID);
            List<int> notAvailbleRoomsId = new List<int>(); ;    
            foreach(var id in bookingRoomsID)
            {
                if (!availbleRoomIDs.Contains(id))
                    notAvailbleRoomsId.Add(id);              
            }
            if(notAvailbleRoomsId.Count>0)
                return notAvailbleRoomsId;
            var customer =  _unitOfWork.CustomerRepo.find(bookingAddDto.Name);
            var bookedPreviously = true;
            if (customer==null)
            {
               customer=await _unitOfWork.CustomerRepo.Add(new Hotel_DAL.Data.Model.Customer() {Name=bookingAddDto.Name,NationalID=bookingAddDto.NationalId,PhoneNumber=bookingAddDto.phoneNumber});
                await _unitOfWork.SaveChangeAsync();
                bookedPreviously = false;
            }
            var TotalPrice =this.calcPrice(bookingAddDto.BookingDate, bookingAddDto.Rooms, bookingAddDto.Name, bookedPreviously);
            var booking = await _unitOfWork.BookingRepo.Add(new Hotel_DAL.Data.Model.Booking()
            {
                BranchID = bookingAddDto.BranchID,
                checkInDate = bookingAddDto.BookingDate.checkInDate.ToDateOnly(),
                checkOutDate = bookingAddDto.BookingDate.checkOutDate.ToDateOnly(),
                CustomerID = customer.Id,
                NumOfRooms = bookingAddDto.NumOfRooms,
                TotalPrice=TotalPrice
            });
            await _unitOfWork.SaveChangeAsync();
            foreach(var room in bookingAddDto.Rooms)
            {
                 _unitOfWork.BookingRepo.addBookingRoom(new BookingRoom() { BookingId=booking.Id,RoomID=room.roomID,NumOfAdults=room.NumberOfAdults,NumOfChildren=room.NumberOfChildren});
            }
            await _unitOfWork.SaveChangeAsync();
            return null;

        }
        public async Task<BookingDetailsDto?> getByIdWithDetails(int id)
        {
            var booking = await _unitOfWork.BookingRepo.getByIdWithDetails(id);
            if (booking == null)
                return null;
            var roomsDto = booking.BookingRooms.Select(r => new BookingRoomDto(r.RoomID,r.Room.Category.RoomType.ToString(),r.NumOfAdults,r.NumOfChildren));
            Console.WriteLine("roomsDto : ",roomsDto);
            return new BookingDetailsDto(booking.Customer.Name, booking.Customer.NationalID, booking.Customer.PhoneNumber,booking.Branch.Name,booking.NumOfRooms,booking.checkInDate,booking.checkOutDate,roomsDto,booking.TotalPrice,booking.BookingDate);
        }
        public double calcPrice(BookingDate bookingDate,RoomAddDto[] rooms,string CustomerName, bool bookedPreviously)
        {
            var startDate = new DateTime(bookingDate.checkInDate.Year,bookingDate.checkInDate.Month,bookingDate.checkInDate.Day);
            var EndDate = new DateTime(bookingDate.checkOutDate.Year,bookingDate.checkOutDate.Month,bookingDate.checkOutDate.Day);
            var days = (EndDate.Date - startDate.Date).Days;
            var TotalPrice = 0;
            foreach (var room in rooms)
            {
                if (room.roomType == 0)
                    TotalPrice += 100 * days;
                else if (room.roomType == 1)
                    TotalPrice += 200 * days;
                else if (room.roomType == 2)
                    TotalPrice += 300 * days;
            }
            if (bookedPreviously)
                return (TotalPrice * 0.05)+TotalPrice;
            return TotalPrice;
        }
        public bool ExistsPrev(string Name)
        {
            var customer=_unitOfWork.CustomerRepo.find(Name);
            if(customer==null)
                return false;
            return true;
        }

    }
}
