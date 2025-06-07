using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productsRepository = new();

		public IActionResult Index()
        {
            return View(productsRepository.GetAll());
        }
    }
}
