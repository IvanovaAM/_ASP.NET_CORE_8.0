using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Repositories
{
	public class ProductRepository
	{
		private static readonly List<Product> products = 
			[
			new Product("Корм для собак мелких пород, 5 кг", 2590.2M, "Корм для собак мелких пород, 5 кг"),
			new Product("Корм для собак средних пород, 5 кг", 3080.8M, "Корм для собак средних пород, 5 кг"),
			new Product("Корм для собак крупных пород, 5 кг", 3770.3M, "Корм для собак крупных пород, 5 кг")
			];

		public List<Product> GetAll()
		{ 
			return products;
		}

		public Product? TryGetById(int id)
		{
			return products.FirstOrDefault(products => products.Id == id);
		}
	}
}
