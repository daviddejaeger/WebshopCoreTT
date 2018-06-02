using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopCoreTT.Models.Domain
{
    public class Product_Attribute
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Product Product { get; set; }
    }
}
