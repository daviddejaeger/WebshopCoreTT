using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopCoreTT.Models.ViewModels.HomeViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Product> PromoProducts { get; set; }
        public IEnumerable<Product> NewProducts { get; set; }
        public IndexViewModel(IEnumerable<Product> promoProducts, IEnumerable<Product> newProducts)
        {
            PromoProducts = promoProducts;
            NewProducts = newProducts;
        }
    }
}
