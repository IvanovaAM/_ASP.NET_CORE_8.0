using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsRepository productsRepository = new();

        public HomeController()
        {
        }

		public IActionResult Index()
        {
            return View(productsRepository.GetProducts());
        }
    }
}
