using Hotel_BL.Dtos.Booking;
using Hotel_BL.Dtos.Room;

namespace Hotel_API.Controllers.Booking
{
    public record BookingAddDto(string Name,string NationalId,string phoneNumber, int BranchID, int NumOfRooms, BookingDate BookingDate, RoomAddDto[] Rooms);

}
