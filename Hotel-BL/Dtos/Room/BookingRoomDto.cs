using Hotel_BL.Dtos.Booking;
using Hotel_DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Dtos.Room
{
    public record BookingRoomDto(string RoomType,int NumOfAdults,int NumOfChildren,DateTime BookingDate);
}
