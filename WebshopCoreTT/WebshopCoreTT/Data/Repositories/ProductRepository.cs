using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebshopCoreTT.Models.Domain;

namespace WebshopCoreTT.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Product> _products;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _products = dbContext.Products;
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            _products.Remove(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public IEnumerable<Product> GetAllNewProducts()
        {
            return _products.Where(p => p.IsNew == true);
        }

        public IEnumerable<Product> GetAllPromoProducts()
        {
            return _products.Where(p => p.OnSale == true);
        }

        public IEnumerable<Rubber> GetAllRubbers()
        {
            return _products.ToList().OfType<Rubber>();
        }

        public Product GetById(int productId)
        {
            return _products.SingleOrDefault(p => p.Id == productId);
        }      

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
