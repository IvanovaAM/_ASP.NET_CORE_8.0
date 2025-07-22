using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index(uint brandId = 0, uint categoryId = 0)
		{
			List<Product>? products = ProductsRepository.GetAll();
			List<ProductBrand>? productBrands = ProductBrandsRepository.GetAll();
			List<ProductCategory>? productsCategories = ProductCategoriesRepository.GetAll();


			var filter = false;
			var currentFilter = string.Empty;

			if (brandId > 0 && categoryId == 0)
			{
				products = products.Where(x => x.BrandId == brandId).ToList();
				filter = true;
				currentFilter = ProductBrandsRepository.GetAll().FirstOrDefault(x => x.Id == brandId)?.Name;
			}

			if (brandId == 0 && categoryId > 0)
			{
				products = products.Where(x => x.CategoryId == categoryId).ToList();
				filter = true;
				currentFilter = ProductCategoriesRepository.GetAll().FirstOrDefault(x => x.Id == categoryId)?.Name;
			}

			products?.OrderBy(x => x.Id);

			List<ProductViewModel>? productsViewModels = null;
			HomeViewModel? homeViewModel = null;

			if (products != null && products.Count > 0 && productBrands.Count > 0 && productsCategories.Count > 0)
			{
				productsViewModels = [];
				foreach (var product in products)
				{
					var obj = new ProductViewModel()
					{
						Product = product,
						ProductBrand = ProductBrandsRepository.TryGetById(product.BrandId),
						ProductCategory = ProductCategoriesRepository.TryGetById(product.CategoryId),
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
