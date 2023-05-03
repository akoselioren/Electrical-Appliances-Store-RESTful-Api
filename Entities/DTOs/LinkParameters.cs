using Entities.RequestFeatures;
using Microsoft.AspNetCore.Http;

namespace Entities.DTOs
{
    public record LinkParameters
    {
        public  ProductParameters ProductParameters { get; init; }
        public HttpContext HttpContext { get; init; }
    }
}
