using Hotel_BL.Dtos.Room;

namespace Hotel_API.Controllers.Booking
{
    public record BookingAddDto(string Customer,string NationalId,string phoneNumber, string BranchID, int NumOfRooms, DateOnly checkInDate, DateOnly checkOutDate,RoomDto[] Rooms);

}
