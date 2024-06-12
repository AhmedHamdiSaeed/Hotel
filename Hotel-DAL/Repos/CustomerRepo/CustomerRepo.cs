using Hotel_DAL.Data.Context;
using Hotel_DAL.Data.Model;
using Hotel_DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Repos.CustomerRepo
{
    public class CustomerRepo:GenericRepo<Customer>,ICustomerRepo
    {
        public CustomerRepo(HotelDbContext hotelDbContext):base(hotelDbContext)
        {
            
        }
    }
}
