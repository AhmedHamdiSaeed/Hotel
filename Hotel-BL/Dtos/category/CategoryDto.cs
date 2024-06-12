using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Dtos.category
{
    public record CategoryDto(int ID,string RoomType,int MaxAdults,int MaxChildren);
}
