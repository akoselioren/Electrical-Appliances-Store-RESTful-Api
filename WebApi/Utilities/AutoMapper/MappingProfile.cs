using AutoMapper;
using Entities.DTOs;
using Entities.Models;

namespace WebApi.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDtoForUpdate, Product>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDtoForInsertion, Product>();
        }
    }
}
