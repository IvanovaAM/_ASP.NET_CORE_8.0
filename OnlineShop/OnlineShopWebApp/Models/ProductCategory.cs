using System.Xml.Linq;

namespace OnlineShopWebApp.Models
{
	public class ProductCategory(string name)
	{
		private static int instanceCounter = 1;
		public int Id { get; } = instanceCounter++;
		public string Name { get; } = name;
	}
}
