using Entities.DTOs;
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
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var products = await _manager.ProductService.GetAllProductsAsync(false);
            return Ok(products);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdProductAsync([FromRoute(Name = "id")] int id)
        {
            var product = await _manager.ProductService.GetByIdAsync(id, false);

            
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAsync([FromBody] ProductDtoForInsertion productDto)
        {
            if (productDto is null)
            {
                return BadRequest(); // 400 Status Code
            }

            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }
            var product = await _manager.ProductService.CreateProductAsync(productDto);

            return StatusCode(201, product);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateProductAsync([FromRoute(Name = "id")] int id, [FromBody] ProductDtoForUpdate productDto)
        {
            if (productDto is null)
            {
                return BadRequest(); //400 Status code
            }
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState); //422 Status code
            }

            await _manager.ProductService.UpdateProductAsync(id, productDto, false);

            return NoContent(); //204 Status code
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProductAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.ProductService.DeleteProductAsync(id, false);
            return NoContent();
        }
    }
}
