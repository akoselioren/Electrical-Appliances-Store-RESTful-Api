using Entities.Exceptions;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;

        public ProductManager(IRepositoryManager manager, ILoggerService logger)
        {
            _manager = manager;
            _logger = logger;
        }

        public Product CreateProduct(Product product)
        {
            _manager.Product.CreateProduct(product);
            _manager.Save();
            return product;
        }

        public void DeleteProduct(int id, bool trackChanges)
        {
            var result = _manager.Product.GetById(id, trackChanges);
            if (result is null)
            {
                throw new ProductNotFoundException(id);
            }

            _manager.Product.DeleteProduct(result);
            _manager.Save();
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _manager.Product.GetAllProducts(trackChanges);
        }

        public Product GetById(int id, bool trackChanges)
        {
            var product =  _manager.Product.GetById(id, trackChanges);
            if (product is null)
            {
                throw new ProductNotFoundException(id);
            }
            return product;
        }

        public void UpdateProduct(int id, Product product, bool trackChanges)
        {
            var result = _manager.Product.GetById(id, trackChanges);
            if (result is null)
            {
                throw new ProductNotFoundException(id);
            }

            result.Title=product.Title;
            result.Price=product.Price;

            _manager.Product.Update(result);
            _manager.Save();

        }
    }
}
