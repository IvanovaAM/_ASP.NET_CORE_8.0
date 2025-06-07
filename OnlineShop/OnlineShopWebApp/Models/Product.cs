namespace OnlineShopWebApp.Models
{
	public class Product(string name, decimal cost, string description)
	{
		private static int instanceCounter = 1;
		public int Id { get;} = instanceCounter++;
		public string Name { get;} = name;
		public decimal Cost { get;} = cost;
		public string Description { get; } = description;
	}
}
