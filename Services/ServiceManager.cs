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
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthenticationService _authenticationService;

        public ServiceManager(IProductService productService, ICategoryService categoryService, IAuthenticationService authenticationService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _authenticationService = authenticationService;
        }

        public IProductService ProductService => _productService;

        public IAuthenticationService AuthenticationService => _authenticationService;

        public ICategoryService CategoryService => _categoryService;
    }
}
