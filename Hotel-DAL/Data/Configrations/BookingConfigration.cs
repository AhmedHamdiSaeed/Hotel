using Hotel_DAL.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Context.Configrations
{
    public class BookingConfigration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasMany(b => b.Rooms)
                .WithMany(r => r.Bookings)
                .UsingEntity<BookingRoom>
                (
                    j => j.HasOne(i => i.Room).WithMany(j => j.BookingRooms).HasForeignKey(j => j.RoomID),
                    j => j.HasOne(i => i.Booking).WithMany(j => j.BookingRooms).HasForeignKey(j => j.BookingId),

                    j =>
                    {
                        j.HasKey(p => new { p.RoomID, p.BookingId });
                        j.Property(p => p.BookingDate).HasDefaultValueSql("GETDATE()");
                    }

                        ); ;
            builder.HasData(
          new Booking() { Id = 1, checkInDate = new DateOnly(2024, 1, 1), checkOutDate = new DateOnly(2024, 1, 10), NumOfRooms = 3, BranchID = 1, CustomerID = 1 },
          new Booking() { Id = 2, checkInDate = new DateOnly(2024, 2, 10), checkOutDate = new DateOnly(2024, 2, 20), NumOfRooms = 3, BranchID = 2, CustomerID = 2 }

          );
        }
    }
}
