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
    [Route("api/books")]
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
            try
            {
                var products = _manager.ProductService.GetAllProducts(false);
                return Ok(products);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpGet("{id:int}")]
        public IActionResult GetByIdProduct([FromRoute(Name = "id")] int id)
        {
            try
            {
                var product = _manager.ProductService.GetById(id, false);

                if (product is null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            try
            {
                if (product is null)
                {
                    return BadRequest();
                }
                _manager.ProductService.CreateProduct(product);

                return StatusCode(201, product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateProduct([FromRoute(Name = "id")] int id, [FromBody] Product product)
        {
            try
            {
                if (product is null)
                {
                    return BadRequest(); //400 Status code
                }

                _manager.ProductService.UpdateProduct(id, product, true);

                return NoContent(); //204 Status code
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct([FromRoute(Name = "id")] int id)
        {
            try
            {
                _manager.ProductService.DeleteProduct(id, false);
                return NoContent();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
