using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _productService = new Lazy<IProductService>(() => new ProductManager(repositoryManager));
        }
        public IProductService ProductService => _productService.Value;
    }
}
