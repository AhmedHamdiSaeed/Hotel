using Hotel_BL.Dtos.category;
using Hotel_DAL.Data.Model;
using Hotel_DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hotel_BL.Managers.Category
{
    public class CategoryManager:ICategoryManager
    {
        private IUnitOfWork _UnitOfWork;
        public CategoryManager(IUnitOfWork unitOfWork)
        {
           _UnitOfWork = unitOfWork;
        }
        public async Task<List<CategoryDto>?> getAll()
        {
           var categories= await _UnitOfWork.CategoryRepo.getAll();
           if (categories == null) return null;
            return categories.ToList().Select(c=>new CategoryDto(c.ID,c.RoomType.ToString(),c.MaxAdults,c.MaxChildren)).ToList();
        }

    }
}
