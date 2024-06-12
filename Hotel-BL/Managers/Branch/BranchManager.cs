using Hotel_BL.Dtos.Branch;
using Hotel_DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Managers.Branch
{
    public class BranchManager:IBranchManager
    {
        private IUnitOfWork _UnitOfWork;
        public BranchManager(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }
        public async Task<List<BranchDto>?> getAll() 
        {
            var Branches =await _UnitOfWork.BranchRepo.getAll();
            if (Branches == null)
                return null;
            return Branches.Select(b=>new BranchDto(b.Id,b.Name)).ToList();
        }

    }
}
