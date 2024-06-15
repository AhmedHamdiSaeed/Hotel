using Hotel_DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Dtos.Booking
{
    public record BookingDto(int id,string Customer,string Branch,int NumOfRooms,DateOnly checkInDate,DateOnly checkOutDate,double TotalPrice);
 
}
