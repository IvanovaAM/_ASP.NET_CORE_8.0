using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ProductsRepository _productsRepository = new();
		private readonly ProductBrandsRepository _productBrandRepository = new();
		private readonly ProductCategoriesRepository _productCategoriesRepository = new();

		public IActionResult Index(uint brandId = 0, uint categoryId = 0)
		{
			List<Product>? products = _productsRepository.GetAll;
			List<ProductBrand>? productBrands = _productBrandRepository.GetAll;
			List<ProductCategory>? productsCategories = _productCategoriesRepository.GetAll;


			var filter = false;
			var currentFilter = string.Empty;

			if (brandId > 0 && categoryId == 0)
			{
				products = products.Where(x => x.ProductBrandId == brandId).ToList();
				filter = true;
				currentFilter = _productBrandRepository?.GetAll?.FirstOrDefault(x => x.Id == brandId)?.Name;
			}

			if (brandId == 0 && categoryId > 0)
			{
				products = products.Where(x => x.ProductCategoryId == categoryId).ToList();
				filter = true;
				currentFilter = _productCategoriesRepository?.GetAll?.FirstOrDefault(x => x.Id == categoryId)?.Name;
			}

			products?.OrderBy(x => x.Id);

			List<ProductViewModel>? productsViewModels = null;
			HomeViewModel? homeViewModel = null;

			if (products.Count > 0 && productBrands.Count > 0 && productsCategories.Count > 0)
			{
				productsViewModels = [];
				foreach (var product in products)
				{
					var obj = new ProductViewModel()
					{
						Product = product,
						ProductBrand = _productBrandRepository?.TryGetById(product.ProductBrandId),
						ProductCategory = _productCategoriesRepository?.TryGetById(product.ProductCategoryId),
					};
					productsViewModels.Add(obj);
				}

				homeViewModel = new()
				{
					ProductsViewModels = productsViewModels,
					IsFilter = filter,
					CurrentFilter = currentFilter
				};
			}
			return View(homeViewModel);
		}
	}
}
