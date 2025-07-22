namespace OnlineShopWebApp.Models
{
	public class ProductViewModel
	{
		public required Product Product { get; set; }
		public required ProductBrand ProductBrand { get; set; }
		public required ProductCategory ProductCategory { get; set; }
	}
}
