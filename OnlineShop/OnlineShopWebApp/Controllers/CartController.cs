using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Interfaces;
using OnlineShopWebApp.Services;

namespace OnlineShopWebApp.Controllers
{
	public class CartController(ICartsService cartsService, IProductsService productsService) : Controller
	{
        public IActionResult Index()
		{
			var cart = cartsService.TryGetByUserId(Constants.UserId);
			
			return View(cart);
		}

		public IActionResult Add(uint productId)
		{
			var product = productsService.TryGetById(productId);

			if (product != null)
			{
                cartsService.Add(product, Constants.UserId);
			}

			return RedirectToAction(nameof(Index));
		}

		public IActionResult Subtract(uint productId)
		{
            cartsService.Subtract(productId);

			return RedirectToAction(nameof(Index));
		}
	}
}
