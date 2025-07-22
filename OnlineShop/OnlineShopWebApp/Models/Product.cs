namespace OnlineShopWebApp.Models
{
	public record Product(uint Id, string Name, uint BrandId, uint CategoryId, decimal Price, string Description, string ShortDescription, string ImagePath)
    {
	}
}
