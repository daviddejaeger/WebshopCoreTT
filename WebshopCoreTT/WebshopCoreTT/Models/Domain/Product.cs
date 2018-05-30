using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopCoreTT.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double SalesPrice { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public bool OnSale { get; set; }
        public bool IsNew { get; set; }
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
    }
}
