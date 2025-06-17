using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Repositories
{
	public class ProductCategoryRepository
	{
		private static readonly List<ProductCategory> categories =
	[
			new ProductCategory("Корм"),
			new ProductCategory("Аксессуары"),
			new ProductCategory("Мебель"),
			new ProductCategory("Переноски"),
	];

		public List<ProductCategory> GetAll()
		{
			return categories;
		}

		public ProductCategory? TryGetById(int id)
		{
			return categories.FirstOrDefault(categories => categories.Id == id);
		}
	}
}
