using Hotel_DAL.Data.Context;
using Hotel_DAL.Data.Model;
using Hotel_DAL.Repos.GenericRepo;
using Hotel_DAL.Repos.RoomRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Repos.NewFolder
{
    public class RoomRepo:GenericRepo<Room>,IRoomRepo
    {
        public RoomRepo(HotelDbContext hotelDbContext):base(hotelDbContext)
        {
            
        }
        public List<Room>? GetAvailableRooms(DateOnly checkInDate, DateOnly checkOutDate, RoomType? roomType = null)
        {
            var bookedRoomIds = _HotelDbContext.BookingRooms.AsNoTracking()
                .Where(br => br.Booking.checkInDate <= checkOutDate && br.Booking.checkOutDate >= checkInDate)
                .Select(br => br.RoomID)
                .Distinct()
                .ToList();

            var availableRoomsQuery = _HotelDbContext.Rooms.AsNoTracking().Include(r=>r.Category).Include(r=>r.Branch)
                .Where(r => !bookedRoomIds.Contains(r.ID));

            if (roomType.HasValue)
            {
                availableRoomsQuery = availableRoomsQuery.Where(r => r.Category.RoomType == roomType);
            }
            
            return availableRoomsQuery.ToList();
        }
        public async Task<List<Room>?> getAllWithCategory()
        {
            var rooms = await _HotelDbContext.Rooms.Include(r=>r.Category).Include(r=>r.Branch).ToListAsync();
            if (rooms==null)
                return null;
            return rooms;
        }
    }
}
