using AutoMapper;
using Entities.DTOs;
using Entities.Exceptions;
using Entities.LinkModels;
using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Contracts;
using Services.Contracts;
using System.Dynamic;
using static Entities.Exceptions.BadRequestException;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IProductLinks _productsLinks;

        public ProductManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper, IProductLinks productsLinks)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
            _productsLinks = productsLinks;
        }

        public async Task<ProductDto> CreateProductAsync(ProductDtoForInsertion productDto)
        {
            var entity = _mapper.Map<Product>(productDto);
            _manager.Product.CreateProduct(entity);
            await _manager.SaveAsync();
            return _mapper.Map<ProductDto>(entity);
        }

        public async Task DeleteProductAsync(int id, bool trackChanges)
        {
            var result = await GetByIdProductAndCheckExists(id, trackChanges);
            _manager.Product.DeleteProduct(result);
            await _manager.SaveAsync();
        }

        public async Task<(LinkResponse linkResponse, MetaData metaData)> GetAllProductsAsync(LinkParameters linkParameters, bool trackChanges)
        {

            if (!linkParameters.ProductParameters.ValidPriceRange)
            {
                throw new PriceOutofRangeBadRequestException();
            }

            var productsWithMetaData = await _manager.Product.GetAllProductsAsync(linkParameters.ProductParameters, trackChanges);
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(productsWithMetaData);
            var links = _productsLinks.TryGenerateLinks(productsDto,linkParameters.ProductParameters.Fields,linkParameters.HttpContext);

            return (links, productsWithMetaData.MetaData);
        }

        public async Task<ProductDto> GetByIdAsync(int id, bool trackChanges)
        {
            var product = await GetByIdProductAndCheckExists(id, trackChanges);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task UpdateProductAsync(int id, ProductDtoForUpdate productDto, bool trackChanges)
        {
            var result = await _manager.Product.GetByIdAsync(id, trackChanges);
            if (result is null)
            {
                throw new ProductNotFoundException(id);
            }
            result = _mapper.Map<Product>(productDto);

            _manager.Product.Update(result);
            await _manager.SaveAsync();

        }

        private async Task<Product> GetByIdProductAndCheckExists(int id, bool trackChanges)
        {
            var result = await _manager.Product.GetByIdAsync(id, trackChanges);
            if (result is null)
            {
                throw new ProductNotFoundException(id);
            }

            return result;
        }
    }
}
