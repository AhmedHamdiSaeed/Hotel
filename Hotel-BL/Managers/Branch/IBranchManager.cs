using Hotel_BL.Dtos.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Managers.Branch
{
    public interface IBranchManager
    {
        Task<List<BranchDto>?> getAll();
    }
}
