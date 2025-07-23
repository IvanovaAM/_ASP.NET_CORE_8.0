using OnlineShopWebApp.Interfaces;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Services;

	public class InMemoryCartsService : ICartsService
	{
		private static readonly List<Cart> _carts = [];

		public Cart? TryGetByUserId(string userId) => _carts.FirstOrDefault(x => x.UserId == userId);

		public void Add(Product product, string userId)
		{
			var existingCart = TryGetByUserId(userId);

			if (existingCart == null)
			{
				var newCart = new Cart
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Items =
                    [
                        CreateNewItem(product)
					]
				};
				_carts.Add(newCart);
			}
			else
			{
				var existingCartItem = existingCart?.Items?.FirstOrDefault(x => x.Product?.Id == product.Id);

				if (existingCartItem == null)
				{
					existingCart?.Items?.Add(CreateNewItem(product));
				}
				else
				{
					existingCartItem.Quantity += 1;
				}
			}
		}

    private static CartItem CreateNewItem(Product product) => new()
    {
        Id = Guid.NewGuid(),
        Product = product,
        Quantity = 1,
    };

    public void Subtract(uint productId)
		{
			var existingCart = TryGetByUserId(Constants.UserId);

			if (existingCart != null)
			{
				var existingCartItem = existingCart?.Items?.FirstOrDefault(x => x.Product?.Id == productId);

				if (existingCartItem != null)
				{
					existingCartItem.Quantity -= 1;

					if (existingCartItem.Quantity < 1)
					{
						Delete(productId);
					}
				}
			}
		}

		public void Delete(uint productId)
		{
			var existingCart = TryGetByUserId(Constants.UserId);

			if (existingCart != null)
			{
				var existingCartItem = existingCart?.Items?.FirstOrDefault(x => x.Product?.Id == productId);

				if (existingCartItem != null)
				{
					existingCart?.Items?.Remove(existingCartItem);
				}
			}
		}

    public void Delete()
    {
        var existingCart = TryGetByUserId(Constants.UserId);

        existingCart?.Items?.Clear();
    }
}