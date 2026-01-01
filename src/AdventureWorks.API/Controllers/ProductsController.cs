using AdventureWorks.Application.DTOs;
using AdventureWorks.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            try
            {
                var products = await _productService.GetAllProductsAsync();

                if(products != null)
                {
                    return Ok(products);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "...", error = ex.Message });
            }
        }
    }
}
