using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.Interfaces;

namespace OnlineShopWebApp.Controllers
{
	public class ProductController(IProductsService productsService, IBrandsService brandsService, ICategoriesService categoriesService) : Controller
	{
        public IActionResult Index(uint id)
		{
			var product = productsService.TryGetById(id);

			ProductViewModel? productViewModel = null;

			if (product != null)
			{
				productViewModel = new ProductViewModel()
				{
					Product = product,
					ProductBrand = brandsService.TryGetById(product.BrandId),
					ProductCategory = categoriesService.TryGetById(product.CategoryId)
				};
			}

			return View(productViewModel);
		}
	}
}
