using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {

        }

        public async Task<Category> CategoryGetByIdAsync(int id, bool trackChanges)
        {
            return await GetById(c => c.CategoryId.Equals(id), trackChanges)
                .SingleOrDefaultAsync();
        }

        public void CreateCategory(Category category) => Create(category);

        public void DeleteCategory(Category category) => Delete(category);
        public void UpdateCategory(Category category) => Update(category);

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges)
        {
            return await GetAll(trackChanges)
                .OrderBy(c => c.CategoryName)
                .ToListAsync();
        }

    }
}
