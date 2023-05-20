
namespace Services.Contracts
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        ICategoryService CategoryService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
