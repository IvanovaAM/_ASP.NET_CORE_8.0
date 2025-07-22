namespace OnlineShopWebApp.Models
{
	public class HomeViewModel
	{
		public List<ProductViewModel>? ProductsViewModels { get; set; }
		public bool IsFilter { get; set; } = false;
		public string? CurrentFilter { get; set; } = null;
	}
}
