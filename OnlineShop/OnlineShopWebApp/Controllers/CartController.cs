using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Interfaces;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
	public class CartController : Controller
	{
		private readonly ICartsService _cartsService;
        public CartController(ICartsService cartsService)
        {
			_cartsService = cartsService;
        }

        public IActionResult Index()
		{
			var cart = _cartsService.TryGetByUserId(Constants.UserId);
			
			return View(cart);
		}

		public IActionResult Add(uint productId)
		{
			var product = ProductsRepository.TryGetById(productId);

			if (product != null)
			{
                _cartsService.Add(product, Constants.UserId);
			}

			return RedirectToAction(nameof(Index));
		}

		public IActionResult Subtract(uint productId)
		{
            _cartsService.Subtract(productId);

			return RedirectToAction(nameof(Index));
		}
	}
}
