using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Hotel_DAL.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace Hotel_DAL.Data.Context
{
    public class HotelDbContext:DbContext
    {
        public DbSet<Booking>Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Branch> Branches{ get; set; }
        public DbSet<BookingRoom> BookingRooms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public HotelDbContext(DbContextOptions<HotelDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
