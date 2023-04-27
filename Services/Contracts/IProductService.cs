using Entities.DTOs;
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
        IEnumerable<ProductDto> GetAllProducts(bool trackChanges);
        Product GetById(int id, bool trackChanges);
        Product CreateProduct(Product product);
        void UpdateProduct(int id, ProductDtoForUpdate productDto, bool trackChanges);
        void DeleteProduct(int id, bool trackChanges);
    }
}
