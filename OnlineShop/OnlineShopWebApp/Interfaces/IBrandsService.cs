using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Interfaces
{
	public interface IBrandsService
	{
		public List<ProductBrand> GetAll();

		public ProductBrand? TryGetById(uint id);
	}
}