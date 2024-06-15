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
        }
    }
}
