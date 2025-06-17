namespace OnlineShopWebApp.Models
{
	public class Cart
	{
		public required List<CartItem> CartItems { get; set; }
		public decimal TotalCost { get; set; }
	}
}
