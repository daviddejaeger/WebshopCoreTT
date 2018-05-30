using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebshopCoreTT.Models;

namespace WebshopCoreTT.Data.Repositories
{
    public interface IProductRepository
    {
        Product GetById(int productId);
        IEnumerable<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void SaveChanges();
        IEnumerable<Product> GetAllPromoProducts();
        IEnumerable<Product> GetAllNewProducts();
    }
}
