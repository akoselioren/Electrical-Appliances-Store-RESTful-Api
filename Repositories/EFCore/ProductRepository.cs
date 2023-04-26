using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateProduct(Product product) => Create(product);

        public void DeleteProduct(Product product) => Delete(product);
        public IQueryable<Product> GetAllProducts(bool trackChanges) => GetAll(trackChanges).OrderBy(p=>p.Id);

        public Product GetById(int id, bool trackChanges) => GetById(p=>p.Id.Equals(id),trackChanges).SingleOrDefault();

        public void UpdateProduct(Product product) => Update(product);
    }
}
