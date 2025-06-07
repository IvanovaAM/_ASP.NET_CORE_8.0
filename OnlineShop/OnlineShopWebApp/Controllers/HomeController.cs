using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System.Diagnostics;

namespace OnlineShopWebApp.Controllers
{
	public class HomeController : Controller
	{
		private static readonly List<Product> products =
			[
				new Product("Корм для собак мелких пород, 5 кг", 2590.2M, "Корм для собак мелких пород, 5 кг"),
				new Product("Корм для собак средних пород, 5 кг", 3080.8M, "Корм для собак средних пород, 5 кг"),
				new Product("Корм для собак крупных пород, 5 кг", 3770.3M, "Корм для собак крупных пород, 5 кг")
			];

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{

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
