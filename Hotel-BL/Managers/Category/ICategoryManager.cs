using Hotel_BL.Dtos.category;
using Hotel_BL.Dtos.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Managers.Category
{
    public interface ICategoryManager
    {
        Task<List<CategoryDto>?> getAll();

    }
}
