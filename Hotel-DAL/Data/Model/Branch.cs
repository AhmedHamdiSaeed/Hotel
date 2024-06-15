using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Data.Model
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
