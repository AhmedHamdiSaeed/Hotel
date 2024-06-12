using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Model
{
    public class Category
    {
        public int ID { get; set; }
        public RoomType RoomType { get; set; }
        public int MaxAdults { get; set; }
        public int MaxChildren { get; set; }
        public List<Room>Categories { get; set; }=new List<Room>();
    }
}
