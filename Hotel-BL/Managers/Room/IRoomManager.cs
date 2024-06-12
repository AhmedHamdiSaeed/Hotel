using Hotel_BL.Dtos.Branch;
using Hotel_BL.Dtos.Room;
using Hotel_DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Managers.Room
{
    public interface IRoomManager
    {
        Task<List<RoomDto>?> getAllWithCategory();
        IEnumerable<RoomDto> GetAvailableRooms(DateModel checkInDate, DateModel checkOutDate, RoomType? roomType = null);

    }
}
