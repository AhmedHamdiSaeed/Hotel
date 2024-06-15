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
    public class BranchConfigrations : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
    new Branch() { Id = 1, Name = "ism" },
    new Branch() { Id = 2, Name = "cairo" }
    );
        }
    }
}
