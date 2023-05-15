using Entities.DTOs;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    //[ApiVersion("1.0")]
    [ServiceFilter(typeof(LogFilterAttribute))]
    [ApiController]
    [Route("api/products")]
    //[ResponseCache(CacheProfileName ="5mins")]
    //[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge =80)]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize]
        [HttpHead]
        [HttpGet(Name = "GetAllProductsAsync")]
        [ServiceFilter(typeof(ValidateMediaTypeAttribute))]
        //[ResponseCache(Duration = 60)]
        public async Task<IActionResult> GetAllProductsAsync([FromQuery] ProductParameters productParameters)
        {
            var linkParameters = new LinkParameters()
            {
                ProductParameters = productParameters,
                HttpContext = HttpContext
            };

            var result = await _manager.ProductService.GetAllProductsAsync(linkParameters, false);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(result.metaData));

            return result.linkResponse.HasLinks ?
                Ok(result.linkResponse.LinkedEntities) :
                Ok(result.linkResponse.ShapedEntities);

        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdProductAsync([FromRoute(Name = "id")] int id)
        {
            var product = await _manager.ProductService.GetByIdAsync(id, false);


            return Ok(product);
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateProductAsync")]
        public async Task<IActionResult> CreateProductAsync([FromBody] ProductDtoForInsertion productDto)
        {
            var product = await _manager.ProductService.CreateProductAsync(productDto);

            return StatusCode(201, product);
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
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
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProductAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.ProductService.DeleteProductAsync(id, false);
            return NoContent();
        }

        [Authorize]
        [HttpOptions]
        public IActionResult GetProductOptions()
        {
            Response.Headers.Add("Allow", "GET, PUT, POST, DELETE, HEAD, OPTIONS");
            return Ok();
        }
    }
}
