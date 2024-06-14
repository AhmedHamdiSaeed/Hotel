using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Dtos.Room
{
    public record RoomAddDto(int roomType,int NumberOfAdults,int NumberOfChildren,int roomID);
    
}
