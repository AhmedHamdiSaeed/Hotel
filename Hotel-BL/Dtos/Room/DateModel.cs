using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Dtos.Room
{
    public class DateModel
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public DateOnly ToDateOnly()
        {
            return new DateOnly(Year, Month, Day);
        }
    }
}
