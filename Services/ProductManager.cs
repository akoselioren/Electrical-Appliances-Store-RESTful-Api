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

        public Product CreateProduct(Product product)
        {
            _manager.Product.CreateProduct(product);
            _manager.Save();
            return product;
        }

        public void DeleteProduct(int id, bool trackChanges)
        {
            var result = _manager.Product.GetById(id, trackChanges);
            if (result is null)
            {
                throw new ProductNotFoundException(id);
            }

            _manager.Product.DeleteProduct(result);
            _manager.Save();
        }

        public IEnumerable<ProductDto> GetAllProducts(bool trackChanges)
        {
            var products = _manager.Product.GetAllProducts(trackChanges);
            return _mapper.Map<IEnumerable<ProductDto>>(products); 
        }

        public Product GetById(int id, bool trackChanges)
        {
            var product =  _manager.Product.GetById(id, trackChanges);
            if (product is null)
            {
                throw new ProductNotFoundException(id);
            }
            return product;
        }

        public void UpdateProduct(int id, ProductDtoForUpdate productDto, bool trackChanges)
        {
            var result = _manager.Product.GetById(id, trackChanges);
            if (result is null)
            {
                throw new ProductNotFoundException(id);
            }
            result = _mapper.Map<Product>(productDto);

            _manager.Product.Update(result);
            _manager.Save();

        }
    }
}
