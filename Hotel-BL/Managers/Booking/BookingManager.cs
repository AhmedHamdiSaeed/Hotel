using Hotel_API.Controllers.Booking;
using Hotel_BL.Dtos.Booking;
using Hotel_DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_DAL.Data.Model;
using Hotel_BL.Dtos.Room;

namespace Hotel_BL.Managers.Booking
{
    public class BookingManager: IBookingManager
    {
        private IUnitOfWork _unitOfWork;
        public BookingManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<BookingDto>?> GetAll()
        {
           var booking= await _unitOfWork.BookingRepo.getAllWithCustomerAndBranch();
            if (booking == null) 
            {
                return null;
            }
            
            return  booking.Select(b=>new BookingDto(b.Id,b.Customer.Name,b.Branch.Name,b.NumOfRooms,b.checkInDate,b.checkOutDate)).ToList();
        }
        public async Task<bool> AddBooking(BookingAddDto bookingAddDto)
        {
            var customer =  _unitOfWork.CustomerRepo.find(bookingAddDto.Name);
            if(customer==null)
            {
               customer=await _unitOfWork.CustomerRepo.Add(new Hotel_DAL.Data.Model.Customer() {Name=bookingAddDto.Name,NationalID=bookingAddDto.NationalId,PhoneNumber=bookingAddDto.phoneNumber});
                await _unitOfWork.SaveChangeAsync();
            }
            var booking= await _unitOfWork.BookingRepo.Add(new Hotel_DAL.Data.Model.Booking()
            {
                BranchID = bookingAddDto.BranchID,
                checkInDate = bookingAddDto.BookingDate.checkInDate.ToDateOnly(),
                checkOutDate = bookingAddDto.BookingDate.checkOutDate.ToDateOnly(),
                CustomerID = customer.Id,
                NumOfRooms = bookingAddDto.NumOfRooms,
            });
            await _unitOfWork.SaveChangeAsync();
            foreach(var room in bookingAddDto.Rooms)
            {
                 _unitOfWork.BookingRepo.addBookingRoom(new BookingRoom() { BookingId=booking.Id,RoomID=room.roomID,NumOfAdults=room.NumberOfAdults,NumOfChildren=room.NumberOfChildren});
            }
            await _unitOfWork.SaveChangeAsync();
            return true;

        }
        public async Task<BookingDetailsDto?> getByIdWithDetails(int id)
        {
            var booking = await _unitOfWork.BookingRepo.getByIdWithDetails(id);
            if (booking == null)
                return null;
            var roomsDto = booking.BookingRooms.Select(r => new BookingRoomDto(r.Room.Category.RoomType.ToString(),r.NumOfAdults,r.NumOfChildren,r.BookingDate));
            return new BookingDetailsDto(booking.Customer.Name, booking.Customer.NationalID, booking.Customer.PhoneNumber,booking.Branch.Name,booking.NumOfRooms,booking.checkInDate,booking.checkOutDate,roomsDto);
        }
        public double calcPrice(BookingDate bookingDate,RoomAddDto[] rooms,string CustomerName)
        {
            bool bookedPreviously = _unitOfWork.BookingRepo.checkBookedPreviously(CustomerName);
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

    }
}
