using Hotel_DAL.Repos.BookingRepo;
using Hotel_DAL.Repos.BranchRepo;
using Hotel_DAL.Repos.CategoryRepo;
using Hotel_DAL.Repos.CustomerRepo;
using Hotel_DAL.Repos.RoomRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Unit
{
    public interface IUnitOfWork
    {
        IBookingRepo BookingRepo { get; }
        ICustomerRepo CustomerRepo { get; }
        IBranchRepo BranchRepo { get; }
        IRoomRepo RoomRepo { get; }
        ICategoryRepo CategoryRepo { get; }

        Task SaveChangeAsync();
    }
}
