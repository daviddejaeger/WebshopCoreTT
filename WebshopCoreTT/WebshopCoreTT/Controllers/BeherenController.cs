using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebshopCoreTT.Data.Repositories;
using WebshopCoreTT.Models.Domain;

namespace WebshopCoreTT.Controllers
{
    public class BeherenController : Controller
    {
        private readonly IProductRepository _productRepository;

        public BeherenController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> products = _productRepository.GetAll();
            return View(products);
        }
    }
}