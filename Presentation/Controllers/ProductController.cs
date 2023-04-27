using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _manager.ProductService.GetAllProducts(false);
            return Ok(products);

        }

        [HttpGet("{id:int}")]
        public IActionResult GetByIdProduct([FromRoute(Name = "id")] int id)
        {
            var product = _manager.ProductService.GetById(id, false);

            
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (product is null)
            {
                return BadRequest();
            }
            _manager.ProductService.CreateProduct(product);

            return StatusCode(201, product);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateProduct([FromRoute(Name = "id")] int id, [FromBody] Product product)
        {
            if (product is null)
            {
                return BadRequest(); //400 Status code
            }

            _manager.ProductService.UpdateProduct(id, product, true);

            return NoContent(); //204 Status code
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct([FromRoute(Name = "id")] int id)
        {
            _manager.ProductService.DeleteProduct(id, false);
            return NoContent();
        }
    }
}
