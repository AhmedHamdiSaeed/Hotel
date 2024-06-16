using Hotel_API.Controllers.Booking;
using Hotel_BL.Dtos.Booking;
using Hotel_BL.Dtos.Room;
using Hotel_BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Managers.Booking
{
    public interface IBookingManager
    {
        object? GetAll(QueryParams queryParams);
        Task<List<int>?> AddBooking(BookingAddDto bookingAddDto);
        Task<BookingDetailsDto?> getByIdWithDetails(int id);
        double calcPrice(BookingDate bookingDate, RoomAddDto[] rooms, string CustomerName, bool bookedPreviously);
        bool ExistsPrev(string Name);
    }
}
