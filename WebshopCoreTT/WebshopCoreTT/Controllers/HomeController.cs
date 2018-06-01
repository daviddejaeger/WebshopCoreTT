using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using WebshopCoreTT.Data.Repositories;
using WebshopCoreTT.Models.ViewModels.HomeViewModels;

namespace WebshopCoreTT.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;

        public HomeController(IStringLocalizer<HomeController> localizer, IProductRepository productRepository)
        {
            _localizer = localizer;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var promoProducts = _productRepository.GetAllPromoProducts();
            var newProducts = _productRepository.GetAllNewProducts();

            var model = new IndexViewModel(promoProducts, newProducts);

            return View(model);
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}