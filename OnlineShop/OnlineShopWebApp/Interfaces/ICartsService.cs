using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Interfaces
{
	public interface ICartsService
	{
		Cart? TryGetByUserId(string userId);

		void Add(Product product, string userId);

		void Subtract(uint productId);

		void Delete(uint productId);

        void Delete();

    }
}