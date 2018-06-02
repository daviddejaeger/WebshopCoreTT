using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebshopCoreTT.Data.Repositories;
using WebshopCoreTT.Models.Domain;

namespace WebshopCoreTT.Controllers
{
    public class RubberController : Controller
    {
        private readonly IProductRepository _productRepository;

        public RubberController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Rubber> rubbers = _productRepository.GetAllRubbers();
            //IEnumerable<Brand>
            foreach (var rubber in rubbers)
            {

            }
            return View();
        }
    }
}