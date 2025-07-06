using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Repositories
{
	public static class CartsRepository
	{
		private static readonly List<Cart> _carts = [];

		public static Cart? TryGetByUserId(string userId) => _carts.FirstOrDefault(x => x.UserId == userId);

		public static void Add(Product product, string userId)
		{
			var existingCart = TryGetByUserId(userId);

			if (existingCart == null)
			{
				var newCart = new Cart
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Items = new List<CartItem>()
					{
						CreateNewItem(product)
					}
				};
				_carts.Add(newCart);
			}
			else
			{
				var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);

				if (existingCartItem == null)
				{
					existingCart.Items.Add(CreateNewItem(product));
				}
				else
				{
					existingCartItem.Quantity += 1;
				}
			}
		}

		private static CartItem CreateNewItem(Product product)
		{
			return new CartItem()
			{
				Id = Guid.NewGuid(),
				Product = product,
				Quantity = 1,
			};
		}

		public static void Subtract(uint productId)
		{
			var existingCart = TryGetByUserId(Constants.UserId);

			if (existingCart != null)
			{
				var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == productId);

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

		public static void Delete(uint productId)
		{
			var existingCart = TryGetByUserId(Constants.UserId);

			if (existingCart != null)
			{
				var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == productId);

				if (existingCartItem != null)
				{
					existingCart.Items.Remove(existingCartItem);
				}
			}
		}


	}
}