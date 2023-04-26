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

        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Product CreateProduct(Product product)
        {
            if (product is null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _manager.Product.CreateProduct(product);
            _manager.Save();
            return product;
        }

        public void DeleteProduct(int id, bool trackChanges)
        {
            var result = _manager.Product.GetById(id, trackChanges);
            if (result is null)
            {
                throw new Exception($"Product with id:{id} could not found.");
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
            return _manager.Product.GetById(id, trackChanges);
        }

        public void UpdateProduct(int id, Product product, bool trackChanges)
        {
            var result = _manager.Product.GetById(id, trackChanges);
            if (result is null)
            {
                throw new Exception($"Product with id:{id} could not found.");
            }
            if (product is null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            result.Title=product.Title;
            result.Price=product.Price;

            _manager.Product.Update(result);
            _manager.Save();

        }
    }
}
