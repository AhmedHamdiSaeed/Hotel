using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Model
{
    public enum RoomType
    {
        
        Single=0,
        Double=1,
        Suite=2

    }
    public class Room
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; } = null!;
        public   Collection<Booking> Bookings { get; set; }=new Collection<Booking>() { };   
        public List<BookingRoom> BookingRooms { get; set; }=new List<BookingRoom>() { };
    }
}
