using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Title = "Buzdolabı", Price = 275 },
                new Product { Id = 2, Title = "Çamaşır Makinası", Price = 250 },
                new Product { Id = 3, Title = "Bulaşık Makinası", Price = 200 }
                );
        }
    }
}
