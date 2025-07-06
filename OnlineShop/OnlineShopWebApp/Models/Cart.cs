using OnlineShopWebApp.Repositories;

namespace OnlineShopWebApp.Models
{
	public class Cart
	{
		public Guid Id { get; set; }
		public string UserId { get; set; }
		public List<CartItem> Items { get; set; }
		public decimal TotalPrice => Items.Sum(x => x.Price);
		public DateTime CreationDateTime { get; set; } = DateTime.Now;	
	}
}
