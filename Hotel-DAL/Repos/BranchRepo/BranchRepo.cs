using Hotel_DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_DAL.Repos.GenericRepo;
using Hotel_DAL.Data.Context;
namespace Hotel_DAL.Repos.BranchRepo
{
    public class BranchRepo:GenericRepo<Branch>,IBranchRepo
    {
        public BranchRepo(HotelDbContext hotelDbContext):base(hotelDbContext)
        {
        }
    }
}
