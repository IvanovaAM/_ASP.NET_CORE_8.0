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
			products.Add(new Product(1, "���� ��� ����� ������ �����, 5 ��", 2590.2M, "���� ��� ����� ������ �����, 5 ��"));
			products.Add(new Product(2, "���� ��� ����� ������� �����, 5 ��", 3080.8M, "���� ��� ����� ������� �����, 5 ��"));
			products.Add(new Product(3, "���� ��� ����� ������� �����, 5 ��", 3770.3M, "���� ��� ����� ������� �����, 5 ��"));

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
