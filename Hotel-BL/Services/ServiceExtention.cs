using Hotel_BL.Managers.Booking;
using Hotel_BL.Managers.Branch;
using Hotel_BL.Managers.Category;
using Hotel_BL.Managers.Room;
using Hotel_DAL.Repos.BookingRepo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Services
{
    public static class ServiceExtention
    {
        public static void AddBLService(this IServiceCollection services)
        {
            services.AddScoped<IBookingManager, BookingManager>();
            services.AddScoped<IBranchManager,BranchManager>();
            services.AddScoped<IRoomManager, RoomManager>();
            services.AddScoped<ICategoryManager,CategoryManager>();
        }
    }
}
