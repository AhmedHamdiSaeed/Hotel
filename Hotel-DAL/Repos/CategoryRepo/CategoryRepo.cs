using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_DAL.Data.Context;
using Hotel_DAL.Data.Model;
using Hotel_DAL.Repos.GenericRepo;

namespace Hotel_DAL.Repos.CategoryRepo
{
    public class CategoryRepo: GenericRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(HotelDbContext hotelDbContext):base(hotelDbContext)
        {
            
        }
    }
}
