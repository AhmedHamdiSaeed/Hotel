using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Model
{
    public class BookingRoom
    {
        public int RoomID { get; set; }
        public int BookingId { get; set; }
        public int NumOfAdults { get; set; }
        public int NumOfChildren { get; set;}
        public DateTime BookingDate { get; set; }
        public Booking Booking { get; set; }=null!;
        public Room Room { get; set; } = null!;
    }
}
