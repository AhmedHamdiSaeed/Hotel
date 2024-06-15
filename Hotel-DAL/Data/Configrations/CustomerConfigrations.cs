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
    public class CustomerConfigrations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
    new Customer() { Id = 1, Name = "ahmed", NationalID = "123423", PhoneNumber = "01092925652" },
    new Customer() { Id = 2, Name = "ali", NationalID = "34543", PhoneNumber = "010929343" }
    );
        }
    }
}
