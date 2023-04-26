using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product GetById(int id, bool trackChanges);
        Product CreateProduct(Product product);
        void UpdateProduct(int id, Product product, bool trackChanges);
        void DeleteProduct(int id, bool trackChanges);
    }
}
