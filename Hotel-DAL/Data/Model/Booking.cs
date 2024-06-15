using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Model
{
    public class Booking
    {
        public int Id { get; set; }

        public DateOnly checkInDate { get; set; }
        public DateOnly checkOutDate { get; set; }
        public double TotalPrice { get; set; }  
        public int NumOfRooms { get; set; }
        public int BranchID { get; set; }
        public int CustomerID { get; set; } 
        public Customer Customer { get; set; }=null!;
        public Branch Branch { get; set; } = null!;
        public Collection<Room> Rooms { get; set; }=new Collection<Room>();
        public List<BookingRoom> BookingRooms { get; set; } = new List<BookingRoom>() { };
    }
}
