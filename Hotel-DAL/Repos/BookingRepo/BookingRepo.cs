using Hotel_DAL.Data.Context;
using Hotel_DAL.Data.Model;
using Hotel_DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Repos.BookingRepo
{
    public class BookingRepo : GenericRepo<Booking>, IBookingRepo
    {
        public BookingRepo(HotelDbContext hotelDbContext):base(hotelDbContext)
        {
           
        }
        public async Task<List<Booking>?> getAllWithCustomerAndBranch()
        {
            return await _HotelDbContext.Bookings.Include(b => b.Branch).Include(b=>b.Customer).ToListAsync();
        }
        public  void addBookingRoom(BookingRoom bookingRoom)
        {
             _HotelDbContext.BookingRooms.Add(bookingRoom);
        }
        public async Task<Booking?> getByIdWithDetails(int id)
        {
           return await _HotelDbContext.Bookings.Include(b=>b.Branch).Include(b=>b.Customer).Include(b=>b.BookingRooms).ThenInclude(br=>br.Room).ThenInclude(r=>r.Category).FirstOrDefaultAsync(b=>b.Id==id);
        }
        public bool checkBookedPreviously(string CustomerName)
        {
           return _HotelDbContext.Bookings.Include(b=>b.Customer).Any(b=>b.Customer.Name==CustomerName);
        }


    }
}
