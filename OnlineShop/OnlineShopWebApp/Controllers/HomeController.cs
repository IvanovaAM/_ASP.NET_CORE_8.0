using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Interfaces;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class HomeController(IBrandsService brandsService, ICategoriesService categoriesService, IProductsService productsService) : Controller
	{
        public IActionResult Index(uint brandId = 0, uint categoryId = 0)
		{
			List<Product>? products = productsService.GetAll();
			List<ProductBrand>? productBrands = brandsService.GetAll();
			List<ProductCategory>? productsCategories = categoriesService.GetAll();


			var filter = false;
			var currentFilter = string.Empty;

			if (brandId > 0 && categoryId == 0)
			{
				products = products.Where(x => x.BrandId == brandId).ToList();
				filter = true;
				currentFilter = brandsService.GetAll().FirstOrDefault(x => x.Id == brandId)?.Name;
			}

			if (brandId == 0 && categoryId > 0)
			{
				products = products.Where(x => x.CategoryId == categoryId).ToList();
				filter = true;
				currentFilter = categoriesService.GetAll().FirstOrDefault(x => x.Id == categoryId)?.Name;
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
						ProductBrand = brandsService.TryGetById(product.BrandId),
						ProductCategory = categoriesService.TryGetById(product.CategoryId),
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
