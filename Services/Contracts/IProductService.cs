using Entities.DTOs;

namespace Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync(bool trackChanges);
        Task<ProductDto> GetByIdAsync(int id, bool trackChanges);
        Task<ProductDto> CreateProductAsync(ProductDtoForInsertion product);
        Task UpdateProductAsync(int id, ProductDtoForUpdate productDto, bool trackChanges);
        Task DeleteProductAsync(int id, bool trackChanges);
    }
}
