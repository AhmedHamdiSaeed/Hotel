using Hotel_BL.Dtos.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Dtos.Booking
{
    public record BookingDetailsDto(string Name, string NationalId, string phoneNumber,string BranchName, int NumOfRooms, DateOnly checkInDate, DateOnly checkOutDate, IEnumerable<BookingRoomDto> Rooms, double TotalPrice,DateTime BookingDate);

}
