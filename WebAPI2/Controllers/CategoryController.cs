using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
             _categoryService = categoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll() //Dependency Chain
        {
            Thread.Sleep(1000);
            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
