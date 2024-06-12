using Hotel_DAL.Data.Context;
using Hotel_DAL.Repos.BookingRepo;
using Hotel_DAL.Repos.BranchRepo;
using Hotel_DAL.Repos.CategoryRepo;
using Hotel_DAL.Repos.CustomerRepo;
using Hotel_DAL.Repos.NewFolder;
using Hotel_DAL.Repos.RoomRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        private HotelDbContext _hotelDbContext;
        public ICustomerRepo CustomerRepo { get; }
        public IBookingRepo BookingRepo { get; }   
        public IBranchRepo BranchRepo { get; }  
        public IRoomRepo RoomRepo { get; }
        public ICategoryRepo CategoryRepo { get; }
        public UnitOfWork(HotelDbContext hotelDbContext,ICustomerRepo customerRepo,IBookingRepo bookingRepo,IBranchRepo branchRepo,IRoomRepo roomRepo, ICategoryRepo categoryRepo)
        {
            _hotelDbContext = hotelDbContext;
            CustomerRepo = customerRepo;
            BookingRepo = bookingRepo;
            BranchRepo = branchRepo;
            RoomRepo = roomRepo;
            CategoryRepo = categoryRepo;
        }
  

        async Task IUnitOfWork.SaveChangeAsync()
        {
           await _hotelDbContext.SaveChangesAsync();
        }
    }
}
