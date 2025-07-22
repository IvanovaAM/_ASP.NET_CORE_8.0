using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Interfaces
{
	public interface IProductsService
	{
		public List<Product> GetAll();

		public Product? TryGetById(uint id);
	}
}
