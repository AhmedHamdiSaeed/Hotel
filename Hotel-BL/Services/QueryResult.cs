using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Services
{
    public record QueryResult(object Data,int TotalPages,int page,int pageSize,int total);
}
