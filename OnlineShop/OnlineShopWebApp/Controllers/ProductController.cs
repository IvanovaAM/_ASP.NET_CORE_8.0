using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index(uint id)
		{
			var product = ProductsRepository.TryGetById(id);

			ProductViewModel? productViewModel = null;

			if (product != null)
			{
				productViewModel = new ProductViewModel()
				{
					Product = product,
					ProductBrand = ProductBrandsRepository.TryGetById(product.BrandId),
					ProductCategory = ProductCategoriesRepository.TryGetById(product.CategoryId)
				};
			}

			return View(productViewModel);
		}
	}
}
