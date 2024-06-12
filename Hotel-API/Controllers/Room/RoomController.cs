using Hotel_API.Extentions;
using Hotel_BL.Dtos.Booking;
using Hotel_BL.Dtos.Branch;
using Hotel_BL.Dtos.Room;
using Hotel_BL.Managers.Branch;
using Hotel_BL.Managers.Room;
using Hotel_DAL.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_API.Controllers.Room
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private IRoomManager _roomManager;
        public RoomController(IRoomManager roomManager)
        {
            _roomManager = roomManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<RoomDto>?>> GetAll()
        {
            var Rooms = await _roomManager.getAllWithCategory();
            if (Rooms == null)
                return NotFound(new ApiResponse(404, $"Rooms Not Found.", string.Empty));
            return Ok(new ApiResponse(200, "success", Rooms));

        }
        [HttpGet("Available")]
        public   ActionResult<IEnumerable<RoomDto>> RoomsAvailable([FromQuery]BookingDate bookingDate, RoomType? roomType)
        {
            var rooms =  _roomManager.GetAvailableRooms(bookingDate.checkInDate, bookingDate.checkOutDate, roomType);
            return Ok(new ApiResponse(200,"success",rooms));
        }

    }
}
