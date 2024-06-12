using Hotel_DAL.Data.Context;
using Hotel_DAL.Repos.BookingRepo;
using Hotel_DAL.Repos.BranchRepo;
using Hotel_DAL.Repos.CategoryRepo;
using Hotel_DAL.Repos.CustomerRepo;
using Hotel_DAL.Repos.NewFolder;
using Hotel_DAL.Repos.RoomRepo;
using Hotel_DAL.Unit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Services
{
    public static class ServicesExtenstion
    {
        public static void AddDALService(this IServiceCollection service, IConfiguration config)
        {
            service.AddDbContext<HotelDbContext>(option =>  option.UseSqlServer(config.GetConnectionString("HotelDB")));
            service.AddScoped<IBookingRepo, BookingRepo>();
            service.AddScoped<ICustomerRepo, CustomerRepo>();
            service.AddScoped<IUnitOfWork,UnitOfWork>();
            service.AddScoped<IBranchRepo, BranchRepo>();
            service.AddScoped<IRoomRepo, RoomRepo>();
            service.AddScoped<ICategoryRepo, CategoryRepo>();
        }

    }
}
