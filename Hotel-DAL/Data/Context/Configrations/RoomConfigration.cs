using Hotel_DAL.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Context.Configrations
{
    public class RoomConfigration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room() { ID=1,CategoryID=1 },
                new Room() { ID = 2, CategoryID = 1 },
                new Room() { ID = 3, CategoryID = 2 },
                new Room() { ID = 4, CategoryID = 1 },
                new Room() { ID = 5, CategoryID = 3 },
                new Room() { ID = 6, CategoryID = 2 },
                new Room() { ID = 7, CategoryID = 3 }

                );
        }
    }
}
