using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebshopCoreTT.Models;

namespace WebshopCoreTT.Data.Repositories
{
    public interface ICategoryRepository
    {
        Category GetById(int categoryId);
        IEnumerable<Category> GetAll();
        void Add(Category category);
        void Delete(Category category);
        void SaveChanges();
    }
}
