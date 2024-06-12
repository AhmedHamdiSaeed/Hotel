using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string NationalID { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
