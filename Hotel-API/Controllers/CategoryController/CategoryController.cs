using Hotel_API.Extentions;
using Hotel_BL.Dtos.category;
using Hotel_BL.Managers.Category;
using Hotel_DAL.Unit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_API.Controllers.CategoryController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<ActionResult<CategoryDto>?> get()
        {
            var categories = await _categoryManager.getAll();
            if (categories == null)
                return NotFound(new ApiResponse(404, $"categories Not Found.", string.Empty));
            return Ok(new ApiResponse(200, "success", categories));
        }
    }
}
