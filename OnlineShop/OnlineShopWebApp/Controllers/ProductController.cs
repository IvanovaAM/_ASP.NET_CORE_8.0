using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
	public class ProductController : Controller
	{
		private readonly ProductsRepository productsRepository = new();

		public IActionResult Index(int id)
		{
			return View(productsRepository.GetProduct(id));
		}
	}
}
