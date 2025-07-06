using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Repositories
{
	public class ProductCategoriesRepository
	{
		private static readonly List<ProductCategory> _categories =
		[
			new ProductCategory("Корм", "Товары для питания животных - лакомства, ветеринарные корма, ",""),
			new ProductCategory("Аксессуары", "Принадлежности для питания, выгула, одежда для животных, уходовая косметика", ""),
			new ProductCategory("Мебель", "Клетки, лежаки, домики", ""),
			new ProductCategory("Переноски", "Товары для перемещения животных", ""),
			new ProductCategory("Игрушки", "Товары для игр и развлечений", ""),
			new ProductCategory("Книги", "Книги, журналы, инструкции по уходу за животными", ""),
			new ProductCategory("ВетАптека", "Медицинские товары, лекарства для животных", "")
		];

		public List<ProductCategory> GetAll => _categories;

		public ProductCategory? TryGetById(uint id) => _categories.FirstOrDefault(x => x.Id == id);
	}
}
