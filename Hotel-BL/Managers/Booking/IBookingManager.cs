using Hotel_BL.Dtos.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Managers.Booking
{
    public interface IBookingManager
    {
        Task<List<BookingDto>?> GetAll();
    }
}
