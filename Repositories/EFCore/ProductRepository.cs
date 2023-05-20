using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.Extensions;

namespace Repositories.EFCore
{
    public sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateProduct(Product product) => Create(product);

        public void DeleteProduct(Product product) => Delete(product);
        public async Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges)
        {
            var products = await GetAll(trackChanges)
                .FilterProducts(productParameters.MinPrice, productParameters.MaxPrice)
                .Search(productParameters.SearchTerm)
                .Sort(productParameters.OrderBy)
                .ToListAsync();

            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber,
                productParameters.PageSize);
        }

        public async Task<List<Product>> GetAllProductsAsync(bool trackChanges)
        {
            return await GetAll(trackChanges)
                .OrderBy(p => p.Id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsWithDetailsAsync(bool trackChanges)
        {
            return await _context
                .Products
                .Include(p => p.Category)
                .OrderBy(p => p.Id)
                .ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id, bool trackChanges) => await GetById(p => p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdateProduct(Product product) => Update(product);
    }
}
