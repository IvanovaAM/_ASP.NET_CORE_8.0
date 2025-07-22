using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Interfaces
{
	public interface ICategoriesService
    {
		public List<ProductCategory> GetAll();

		public ProductCategory? TryGetById(uint id);
	}
}
