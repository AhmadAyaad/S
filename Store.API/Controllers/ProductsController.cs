using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Common.DTOS;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddNewProduct(ProductDTO productDTO)
        {
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
