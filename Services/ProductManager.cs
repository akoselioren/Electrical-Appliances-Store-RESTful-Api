using AutoMapper;
using Entities.DTOs;
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
        private readonly IMapper _mapper;

        public ProductManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateProductAsync(ProductDtoForInsertion productDto)
        {
            var entity= _mapper.Map<Product>(productDto);
            _manager.Product.CreateProduct(entity);
           await _manager.SaveAsync();
            return _mapper.Map<ProductDto>(entity);
        }

        public async Task DeleteProductAsync(int id, bool trackChanges)
        {
            var result = await _manager.Product.GetByIdAsync(id, trackChanges);
            if (result is null)
            {
                throw new ProductNotFoundException(id);
            }

            _manager.Product.DeleteProduct(result);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync(bool trackChanges)
        {
            var products = await _manager.Product.GetAllProductsAsync(trackChanges);
            return _mapper.Map<IEnumerable<ProductDto>>(products); 
        }

        public async Task<ProductDto> GetByIdAsync(int id, bool trackChanges)
        {
            var product = await _manager.Product.GetByIdAsync(id, trackChanges);
            if (product is null)
            {
                throw new ProductNotFoundException(id);
            }
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
    }
}
