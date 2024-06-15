﻿using Hotel_API.Extentions;
using Hotel_BL.Dtos.Booking;
using Hotel_BL.Managers.Booking;
using Hotel_DAL.Data.Model;
using Hotel_DAL.Unit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


        [HttpPost]
        public async Task<ActionResult> Booking(BookingAddDto booking)
        {
            var bookedPreviously = _bookingManager.ExistsPrev(booking.Name);
            var message = await _bookingManager.AddBooking(booking);
            if (message != null)
            {
                return BadRequest(new ApiResponse(400, "These rooms ID are not available", message));
            }
            var TotalPrice = _bookingManager.calcPrice(booking.BookingDate,booking.Rooms,booking.Name, bookedPreviously);
            return Ok(new ApiResponse(200, "success", TotalPrice));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookingDto>> GetByIdWithRooms(int id)
        {
            var booking =await _bookingManager.getByIdWithDetails(id);
            if(booking==null)
                return NotFound(new ApiResponse(404, $"Booking Not Found.", string.Empty));
            return Ok(new ApiResponse(200, "success", booking));

        }


    }
}
