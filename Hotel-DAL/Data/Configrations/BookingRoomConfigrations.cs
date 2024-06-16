using Hotel_DAL.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Configrations
{
    public class BookingRoomConfigrations : IEntityTypeConfiguration<BookingRoom>
    {
        public void Configure(EntityTypeBuilder<BookingRoom> builder)
        {
            builder.HasOne(br => br.Booking).WithMany(b=>b.BookingRooms).HasForeignKey(f=>f.BookingId);
            builder.HasOne(br => br.Room).WithMany(r=>r.BookingRooms).HasForeignKey(f=>f.RoomID);
            builder.HasKey(b => new { b.RoomID, b.BookingId });




            builder.HasData(
                new BookingRoom() { BookingId = 1, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 2, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 3, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 4, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 5, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 6, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 7, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 8, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 9, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 10, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 11, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 12, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 13, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 14, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 15, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 16, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 17, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 18, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 19, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 20, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 21, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 22, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 23, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 24, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 25, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 26, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 27, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 28, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 29, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 },
                new BookingRoom() { BookingId = 30, RoomID = 1, NumOfAdults = 1, NumOfChildren = 1 }
                );
        }
    }
}
