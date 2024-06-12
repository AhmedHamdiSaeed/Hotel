using Hotel_DAL.Data.Model;
using Hotel_DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Repos.CustomerRepo
{
    public interface ICustomerRepo:IGenericRepo<Customer>
    {
    }
}
