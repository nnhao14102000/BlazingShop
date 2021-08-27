using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categorySevice;

        public CategoriesController(ICategoryService categoryService)
        {
            _categorySevice = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categorySevice.GetCategories());
        }
    }
}
