using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
	public class CartController : Controller
	{
		private readonly ProductsRepository _productRepository = new();

		public IActionResult Index()
		{
			var cart = CartsRepository.TryGetByUserId(Constants.UserId);
			
			return View(cart);
		}

		public IActionResult Add(uint productId)
		{
			var product = _productRepository.TryGetById(productId);

			if (product != null)
			{
				CartsRepository.Add(product, Constants.UserId);
			}

			return RedirectToAction(nameof(Index));
		}

		public IActionResult Subtract(uint productId)
		{
			CartsRepository.Subtract(productId);

			return RedirectToAction(nameof(Index));
		}
	}
}
