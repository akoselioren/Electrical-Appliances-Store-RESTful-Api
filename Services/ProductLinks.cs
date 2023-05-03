using Entities.DTOs;
using Entities.LinkModels;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Net.Http.Headers;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductLinks : IProductLinks
    {
        private readonly LinkGenerator _linkGenerator;
        private readonly IDataShaper<ProductDto> _dataShaper;

        public ProductLinks(LinkGenerator linkGenerator, IDataShaper<ProductDto> dataShaper)
        {
            _linkGenerator = linkGenerator;
            _dataShaper = dataShaper;
        }

        public LinkResponse TryGenerateLinks(IEnumerable<ProductDto> productDto, string fields, HttpContext httpContext)
        {
            var shapedProducts = ShapeData(productDto, fields);
            if (ShouldGenerateLinks(httpContext))
            {
                return ReturnLinkedProducts(productDto, fields, httpContext, shapedProducts);
            }
            return ReturnShapedProducts(shapedProducts);
        }

        private LinkResponse ReturnLinkedProducts(IEnumerable<ProductDto> productDto, string fields, HttpContext httpContext, List<Entity> shapedProducts)
        {
            var productDtoList = productDto.ToList();

            for (int index = 0; index < productDtoList.Count; index++)
            {
                var productLinks = CreateForProduct(httpContext, productDtoList
                    [index], fields);
                shapedProducts[index].Add("Links", productLinks);
            }
            var productCollection = new LinkCollectionWrapper<Entity>(shapedProducts);
            CreateForProduct(httpContext, productCollection);
            return new LinkResponse { HasLinks = true, LinkedEntities = productCollection };
        }

        private LinkCollectionWrapper<Entity> CreateForProduct(HttpContext httpContext, LinkCollectionWrapper<Entity> productCollectionWrapper)
        {
            productCollectionWrapper.Links.Add(new Link()
            {
                Href = $"/api/{httpContext.GetRouteData().Values["controller"].ToString().ToLower()}s",
                Rel = "self",
                Method = "GET"
            });
            return productCollectionWrapper;
        }

        private List<Link> CreateForProduct(HttpContext httpContext, ProductDto productDto, string fields)
        {
            var links = new List<Link>()
            {
                new Link()
                {
                    Href = $"/api/{httpContext.GetRouteData().Values["controller"].ToString().ToLower()}s" + $"/{productDto.Id}",
                    Rel = "self",
                    Method = "GET"
                },
                new Link()
                 {
                    Href = $"/api/{httpContext.GetRouteData().Values["controller"].ToString().ToLower()}s",
                    Rel = "create",
                    Method = "POST"
                },
            };
            return links;

        }

        private LinkResponse ReturnShapedProducts(List<Entity> shapedProducts)
        {
            return new LinkResponse() { ShapedEntities = shapedProducts };
        }

        private bool ShouldGenerateLinks(HttpContext httpContext)
        {
            var mediaType = (MediaTypeHeaderValue)httpContext.Items["AcceptHeaderMediaType"];
            return mediaType
                .SubTypeWithoutSuffix
                .EndsWith("hateoas", StringComparison.InvariantCultureIgnoreCase);
        }

        private List<Entity> ShapeData(IEnumerable<ProductDto> productDto, string fields)
        {
            return _dataShaper.ShapeData(productDto, fields)
                 .Select(p => p.Entity).ToList();
        }
    }
}
