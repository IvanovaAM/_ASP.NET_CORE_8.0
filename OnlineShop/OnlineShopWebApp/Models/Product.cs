namespace OnlineShopWebApp.Models
{
	public class Product(string name, uint brandId, uint categoryId, decimal price, string description, string shortDescription, string imagePath)
	{
		private static uint instanceCounter = 1;
		public uint Id { get; } = instanceCounter++;
		public string Name { get; } = name;
		public uint ProductBrandId { get; } = brandId;
		public uint ProductCategoryId { get; } = categoryId;
		public decimal Price { get; } = price;
		public string Description { get; } = description;
		public string ShortDescription { get; set; } = shortDescription;
		public string ImagePath { get; set; } = imagePath;
	}
}
