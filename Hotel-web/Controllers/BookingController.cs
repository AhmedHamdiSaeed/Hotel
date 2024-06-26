﻿using Hotel_web.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_web.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult BookingList()
        {
            return View();
        }
        public IActionResult CreateBooking()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LoadPartialView(int number)
        {
            return PartialView("_roomView", number);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {

            return View(id);
        }
        [HttpGet]
        public IActionResult created(double TotalPrice)
        {
            return View(TotalPrice);
        }
    }
}
