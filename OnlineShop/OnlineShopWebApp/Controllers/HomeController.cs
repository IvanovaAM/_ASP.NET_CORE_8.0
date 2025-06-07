using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System.Diagnostics;

namespace OnlineShopWebApp.Controllers
{
	public class HomeController : Controller
	{
		private static readonly List<Product> products =
			[
				new Product("���� ��� ����� ������ �����, 5 ��", 2590.2M, "���� ��� ����� ������ �����, 5 ��"),
				new Product("���� ��� ����� ������� �����, 5 ��", 3080.8M, "���� ��� ����� ������� �����, 5 ��"),
				new Product("���� ��� ����� ������� �����, 5 ��", 3770.3M, "���� ��� ����� ������� �����, 5 ��")
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
