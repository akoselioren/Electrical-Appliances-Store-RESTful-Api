using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges);
        Task<List<Product>> GetAllProductsAsync(bool trackChanges);
        Task<Product> GetByIdAsync(int id, bool trackChanges);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

        Task<IEnumerable<Product>> GetAllProductsWithDetailsAsync(bool trackChanges);

    }
}
