using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Repositories
{
	public class ProductsRepository
	{
		private readonly List<Product> products = [];

		public ProductsRepository()
		{
			products.Add(new Product(1, "Корм для собак мелких пород, 5 кг", 2590.2M, "Корм для собак мелких пород, 5 кг"));
			products.Add(new Product(2, "Корм для собак средних пород, 5 кг", 3080.8M, "Корм для собак средних пород, 5 кг"));
			products.Add(new Product(3, "Корм для собак крупных пород, 5 кг", 3770.3M, "Корм для собак крупных пород, 5 кг"));
		}

		public List<Product> GetProducts()
		{ 
			return products;
		}

		public Product GetProduct(int id)
		{
			 var product = products.First(products => products.Id == id);
			return product;
		}
	}
}
