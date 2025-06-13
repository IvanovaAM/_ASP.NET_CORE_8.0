using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Repositories
{
	public class ProductRepository
	{
		private static readonly List<Product> products = 
			[
			new Product("Корм для собак мелких пород, 5 кг", 2590.2M, "Корм для собак мелких пород, 5 кг"),
			new Product("Корм для собак средних пород, 5 кг", 3080.8M, "Корм для собак средних пород, 5 кг"),
			new Product("Корм для собак крупных пород, 5 кг", 3770.3M, "Корм для собак крупных пород, 5 кг"),
			new Product("Миска для собак", 420.9M, "Миска для собак"),
			new Product("Миска для кошек", 340.6M, "Миска для кошек"),
			new Product("Переноска для собак мелких пород", 3230.1M, "Переноска для собак мелких пород"),
			new Product("Лежанка для собак средних пород", 2040.6M, "Лежанка для собак средних пород"),
			new Product("Игрушка-мышь для кошек", 570.2M, "Игрушка-мышь для кошек"),
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
