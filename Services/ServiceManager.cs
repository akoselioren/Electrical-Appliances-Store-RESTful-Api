using AutoMapper;
using Entities.DTOs;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerService logger, IMapper mapper, IProductLinks productLinks)
        {
            _productService = new Lazy<IProductService>(() =>
            new ProductManager(repositoryManager,logger, mapper, productLinks));
        }
        public IProductService ProductService => _productService.Value;
    }
}
