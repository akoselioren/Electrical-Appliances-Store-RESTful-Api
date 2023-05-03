using Entities.DTOs;
using Entities.LinkModels;
using Microsoft.AspNetCore.Http;

namespace Services.Contracts
{
    public interface IProductLinks
    {
        LinkResponse TryGenerateLinks(IEnumerable<ProductDto> productDto, string fields, HttpContext httpContext);
    }
}
