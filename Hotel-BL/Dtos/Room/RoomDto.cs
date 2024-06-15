using Hotel_DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Dtos.Room
{
    public record RoomDto(int ID,string RoomType,int MaxChildren,int MaxAdults,int BranchID);
}
