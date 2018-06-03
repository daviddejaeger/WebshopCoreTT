using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebshopCoreTT.Data.Repositories;
using WebshopCoreTT.Models.Domain;
using WebshopCoreTT.Models.ViewModels.RubberViewModels;

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

            Dictionary<string, int> manufacturerCounterDictionary = new Dictionary<string, int>();

            foreach (var rubber in rubbers)
            {
                if (manufacturerCounterDictionary.ContainsKey(rubber.Manufacturer))
                {
                    manufacturerCounterDictionary[rubber.Manufacturer] = manufacturerCounterDictionary[rubber.Manufacturer] + 1;
                }
                else
                {
                    manufacturerCounterDictionary.Add(rubber.Manufacturer, 1);
                }
            }

            var model = new IndexViewModel(rubbers, manufacturerCounterDictionary);

            return View(model);
        }
    }
}