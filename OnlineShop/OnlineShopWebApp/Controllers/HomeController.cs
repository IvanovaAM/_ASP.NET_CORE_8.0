using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
		private readonly List<Product> products = [];

		private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
			products.Add(new Product(1, "Корм для собак мелких пород, 5 кг", 2590.2M, "Корм для собак мелких пород, 5 кг"));
			products.Add(new Product(2, "Корм для собак средних пород, 5 кг", 3080.8M, "Корм для собак средних пород, 5 кг"));
			products.Add(new Product(3, "Корм для собак крупных пород, 5 кг", 3770.3M, "Корм для собак крупных пород, 5 кг"));

			_logger = logger;
        }

        public IActionResult Index()
        {
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
