namespace OnlineShopWebApp.Models
{
	public class CartItem
	{
		public Guid Id { get; set; } 
		public Product? Product { get; set; }
		public int Quantity { get; set; }
		public decimal? Price => Product?.Price * Quantity;
	}
}
