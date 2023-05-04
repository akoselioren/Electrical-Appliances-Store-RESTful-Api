using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    //[ApiVersion("2.0", Deprecated = true)]
    [ApiController]
    [Route("api/products")]
    public class ProductV2Controller : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ProductV2Controller(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var products = await _manager.ProductService.GetAllProductsAsync(false);
            var productsV2 = products.Select(p => new
            {
                Title = p.Title,
                Id = p.Id
            });
            return Ok(productsV2);
        }
    }
}
