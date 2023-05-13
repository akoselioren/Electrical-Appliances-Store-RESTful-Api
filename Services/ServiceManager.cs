using AutoMapper;
using Entities.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IAuthenticationService> _authenticationService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerService logger, IMapper mapper, UserManager<User> userManager, IProductLinks productLinks, IConfiguration configuration)
        {
            _productService = new Lazy<IProductService>(() =>
            new ProductManager(repositoryManager, logger, mapper, productLinks));
            _authenticationService = new Lazy<IAuthenticationService>(() =>
            new AuthenticationManager(logger,mapper,userManager, configuration));
        }
        public IProductService ProductService => _productService.Value;

        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
