using Hotel_BL.Dtos.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Dtos.Booking
{
    public record BookingDate(DateModel checkInDate,DateModel checkOutDate);
}
