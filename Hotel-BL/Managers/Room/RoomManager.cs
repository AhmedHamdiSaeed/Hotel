using Hotel_BL.Dtos.Branch;
using Hotel_BL.Dtos.Room;
using Hotel_DAL.Data.Model;
using Hotel_DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Managers.Room
{
    public class RoomManager : IRoomManager
    {
        private IUnitOfWork _UnitOfWork;
        public RoomManager(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }
        public async Task<List<RoomDto>?> getAllWithCategory()

        {
            var Rooms = await _UnitOfWork.RoomRepo.getAllWithCategory();
            if (Rooms == null)
                return null;
            return Rooms.Select(r => new RoomDto(r.ID, r.Category.RoomType.ToString(), r.Category.MaxChildren, r.Category.MaxAdults)).ToList();
        }
        public  IEnumerable<RoomDto> GetAvailableRooms(DateModel checkInDate, DateModel checkOutDate, RoomType? roomType = null)
        {
            
           var rooms= _UnitOfWork.RoomRepo.GetAvailableRooms(checkInDate.ToDateOnly(), checkOutDate.ToDateOnly(), roomType);
        return rooms.Select(r => new RoomDto(r.ID, r.Category.RoomType.ToString(), r.Category.MaxAdults, r.Category.MaxChildren)).ToList();
        }

    }
}
