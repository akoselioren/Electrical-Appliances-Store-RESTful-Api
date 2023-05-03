using Entities.DTOs;
using Entities.LinkModels;
using Entities.RequestFeatures;
using System.Dynamic;

namespace Services.Contracts
{
    public interface IProductService
    {
        Task<(LinkResponse linkResponse, MetaData metaData)> GetAllProductsAsync(LinkParameters linkParameters, bool trackChanges);
        Task<ProductDto> GetByIdAsync(int id, bool trackChanges);
        Task<ProductDto> CreateProductAsync(ProductDtoForInsertion product);
        Task UpdateProductAsync(int id, ProductDtoForUpdate productDto, bool trackChanges);
        Task DeleteProductAsync(int id, bool trackChanges);
    }
}
