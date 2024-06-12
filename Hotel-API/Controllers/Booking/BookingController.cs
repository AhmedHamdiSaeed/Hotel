using Hotel_API.Extentions;
using Hotel_BL.Dtos.Booking;
using Hotel_BL.Managers.Booking;
using Hotel_DAL.Unit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_API.Controllers.Booking
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public IBookingManager _bookingManager;
        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }


        [HttpGet]
        public async Task<ActionResult<BookingDto>> GetAll()
        {
          var Bookings= await _bookingManager.GetAll();
          if (Bookings == null)
            {
                return NotFound(new ApiResponse(404, $"Bookings Not Found.", string.Empty));
            }
            return Ok(new ApiResponse(200, "success", Bookings));
        }
        //[HttpPost]
        //public async Task<ActionResult<BookingAddDto>> Booking(BookingAddDto booking)
        //{

            
        //}


    }
}
