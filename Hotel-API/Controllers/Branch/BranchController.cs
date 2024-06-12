using Hotel_API.Extentions;
using Hotel_BL.Dtos.Branch;
using Hotel_BL.Managers.Branch;
using Hotel_DAL.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_API.Controllers.Branch
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private IBranchManager _branchManager;
        public BranchController(IBranchManager branchManager)
        {
            _branchManager = branchManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<BranchDto>?>> GetAll()
            {
            var Branches = await _branchManager.getAll();
            if(Branches==null)
                return NotFound(new ApiResponse(404, $"Branches Not Found.", string.Empty));
            return Ok(new ApiResponse(200,"success", Branches));

        }
    }
}
