using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateProduct(Product product) => Create(product);

        public void DeleteProduct(Product product) => Delete(product);
        public async Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges)
        {
            var products = await GetAll(trackChanges)
                .OrderBy(p => p.Id)
                .ToListAsync();

            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber,
                productParameters.PageSize);
        }

        public async Task<Product> GetByIdAsync(int id, bool trackChanges) => await GetById(p => p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdateProduct(Product product) => Update(product);
    }
}
