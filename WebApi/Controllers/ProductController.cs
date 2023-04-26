using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
                var products = _context.Products.ToList();
                return Ok(products);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneProducts([FromRoute(Name = "id")] int id)
        {
            try
            {
                var product = _context.Products.Where(p => p.Id.Equals(id)).SingleOrDefault();

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
                _context.Products.Add(product);
                _context.SaveChanges();
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
                var result = _context.Products.Where(p => p.Id.Equals(id)).SingleOrDefault();

                if (result is null)
                {
                    return NotFound(); //404 Status code
                }

                if (id != product.Id)
                {
                    return BadRequest(); //400 Status code
                }

                result.Title = product.Title;
                result.Price = product.Price;

                _context.SaveChanges();
                return Ok(product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProducts([FromRoute(Name = "id")] int id)
        {
            try
            {
                var result = _context.Products.Where(p => p.Id.Equals(id)).SingleOrDefault();
                if (result is null)
                {
                    return NotFound(); //404 Status code
                }

                _context.Products.Remove(result);
                _context.SaveChanges();
                return NoContent();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
