namespace OnlineShopWebApp.Models
{
	public class ProductBrand(string name, string description, string imagePath)
	{
		private static uint instanceCounter = 1;
		public uint Id { get; } = instanceCounter++;
		public string Name { get; } = name;
		public string Description { get; set; } = description;
		public string ImagePath { get; set; } = imagePath;
	}
}
