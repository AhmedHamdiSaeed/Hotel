namespace Hotel_web.Dtos
{
    public record BookingDTO
    (int Id,DateOnly CheckInDate,DateOnly CheckOutDate,int NumOfRooms,int BranchID,int CustomerID,List<RoomDTO> Rooms);
   

    public record RoomDTO
    ( int ID, int CategoryID, string CategoryName);
}
