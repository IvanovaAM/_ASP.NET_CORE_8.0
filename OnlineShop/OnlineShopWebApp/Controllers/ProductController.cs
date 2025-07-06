using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
	public class ProductController : Controller
	{
		private readonly ProductsRepository _productsRepository = new();
		private readonly ProductBrandsRepository _productBrandRepository = new();
		private readonly ProductCategoriesRepository _productCategoriesRepository = new();


		public IActionResult Index(uint id)
		{
			var product = _productsRepository.TryGetById(id);

			ProductViewModel? productViewModel = null;

			if (product != null)
			{
				productViewModel = new ProductViewModel()
				{
					Product = product,
					ProductBrand = _productBrandRepository.TryGetById(product.ProductBrandId),
					ProductCategory = _productCategoriesRepository.TryGetById(product.ProductCategoryId)
				};
			}

			return View(productViewModel);
		}
	}
}
