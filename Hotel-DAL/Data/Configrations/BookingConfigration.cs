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
          

            

            builder.Property(p => p.BookingDate).HasDefaultValueSql("GETDATE()");






            builder.HasData(
            new Booking() { Id = 1, checkInDate = new DateOnly(2024, 12, 1), checkOutDate = new DateOnly(2024, 12, 5), CustomerID = 1, NumOfRooms = 1, BranchID = 1     , TotalPrice=2000  },
                new Booking() { Id = 2, checkInDate = new DateOnly(2024, 12, 6), checkOutDate = new DateOnly(2024, 12, 10), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 3, checkInDate = new DateOnly(2024, 12, 11), checkOutDate = new DateOnly(2024, 12, 15), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 4, checkInDate = new DateOnly(2024, 12, 16), checkOutDate = new DateOnly(2024, 12, 20), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 5, checkInDate = new DateOnly(2024, 12, 21), checkOutDate = new DateOnly(2024, 12, 25), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 6, checkInDate = new DateOnly(2024, 12, 26), checkOutDate = new DateOnly(2024, 12, 30), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 7, checkInDate = new DateOnly(2024, 1, 1), checkOutDate = new DateOnly(2024, 1, 5), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 8, checkInDate = new DateOnly(2024, 1, 6), checkOutDate = new DateOnly(2024, 1, 10), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 9, checkInDate = new DateOnly(2024, 1, 11), checkOutDate = new DateOnly(2024, 1, 15), CustomerID = 1, NumOfRooms = 1, BranchID = 1 , TotalPrice = 2000 },
                new Booking() { Id = 10, checkInDate = new DateOnly(2024, 1, 16), checkOutDate = new DateOnly(2024, 1, 20), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 11, checkInDate = new DateOnly(2024, 1, 21), checkOutDate = new DateOnly(2024, 1, 25), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 12, checkInDate = new DateOnly(2024, 1, 26), checkOutDate = new DateOnly(2024, 1, 30), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 13, checkInDate = new DateOnly(2024, 2, 1), checkOutDate = new DateOnly(2024, 2, 5), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 14, checkInDate = new DateOnly(2024, 2, 6), checkOutDate = new DateOnly(2024, 2, 10), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 15, checkInDate = new DateOnly(2024, 2, 11), checkOutDate = new DateOnly(2024, 2, 15), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 16, checkInDate = new DateOnly(2024, 2, 16), checkOutDate = new DateOnly(2024, 2, 20), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 17, checkInDate = new DateOnly(2024, 2, 21), checkOutDate = new DateOnly(2024, 2, 25), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 18, checkInDate = new DateOnly(2024, 2, 26), checkOutDate = new DateOnly(2024, 2, 27), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 19, checkInDate = new DateOnly(2024, 2, 28), checkOutDate = new DateOnly(2024, 2, 29), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 20, checkInDate = new DateOnly(2024, 3, 1), checkOutDate = new DateOnly(2024, 3, 2), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 21, checkInDate = new DateOnly(2024, 3, 3), checkOutDate = new DateOnly(2024, 3, 5), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 22, checkInDate = new DateOnly(2024, 3, 6), checkOutDate = new DateOnly(2024, 3, 8), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 23, checkInDate = new DateOnly(2024, 3, 9), checkOutDate = new DateOnly(2024, 3, 11), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 24, checkInDate = new DateOnly(2024, 3, 12), checkOutDate = new DateOnly(2024, 3, 14), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 25, checkInDate = new DateOnly(2024, 3, 15), checkOutDate = new DateOnly(2024, 3, 19), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 26, checkInDate = new DateOnly(2024, 3, 20), checkOutDate = new DateOnly(2024, 3, 23), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 27, checkInDate = new DateOnly(2024, 3, 24), checkOutDate = new DateOnly(2024, 3, 26), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 28, checkInDate = new DateOnly(2024, 3, 27), checkOutDate = new DateOnly(2024, 3, 30), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 29, checkInDate = new DateOnly(2024, 4, 1), checkOutDate = new DateOnly(2024, 4, 5), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 },
                new Booking() { Id = 30, checkInDate = new DateOnly(2024, 4, 10), checkOutDate = new DateOnly(2024, 4, 15), CustomerID = 1, NumOfRooms = 1, BranchID = 1, TotalPrice = 2000 }

                );
        }
    }
}
