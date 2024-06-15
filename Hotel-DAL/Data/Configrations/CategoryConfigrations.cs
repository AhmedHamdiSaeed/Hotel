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
    public class CategoryConfigrations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
             new Category() { ID = 1, RoomType = RoomType.Single, MaxAdults = 1, MaxChildren = 2 },
             new Category() { ID = 2, RoomType = RoomType.Double, MaxAdults = 2, MaxChildren = 3 },
             new Category() { ID = 3, RoomType = RoomType.Suite, MaxAdults = 3, MaxChildren = 5 }

             );
            builder.Property(p => p.RoomType).HasConversion<string>();

        }
    }
}
