using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebshopCoreTT.Models.Domain;

namespace WebshopCoreTT.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Category> _categories;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _categories = dbContext.Categories;
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categories.Include(c => c.Products);
        }

        public Category GetById(int categoryId)
        {
            return _categories.SingleOrDefault(c => c.Id == categoryId);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
