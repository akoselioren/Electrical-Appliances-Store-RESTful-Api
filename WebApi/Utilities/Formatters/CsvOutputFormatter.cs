using Entities.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System.Text;
using WebApi.Utilities.Formatters;

namespace WebApi.Utilities.Formatters
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }

        protected override bool CanWriteType(Type? type)
        {
            if (typeof(ProductDto).IsAssignableFrom(type) ||
                typeof(IEnumerable<ProductDto>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }
            return false;
        }

        private static void FormatCsv(StringBuilder buffer, ProductDto product)
        {
            buffer.AppendLine($"{product.Id},{product.Title},{product.Price}");
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;
            var buffer = new StringBuilder();

            if (context.Object is IEnumerable<ProductDto>)
            {
                foreach (var product in (IEnumerable<ProductDto>)context.Object)
                {
                    FormatCsv(buffer, product);
                }
            }
            else
            {
                FormatCsv(buffer, (ProductDto)context.Object);
            }
            await response.WriteAsync(buffer.ToString());
        }
    }
}