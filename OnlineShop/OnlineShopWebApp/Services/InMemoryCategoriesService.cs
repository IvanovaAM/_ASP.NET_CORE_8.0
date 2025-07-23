using OnlineShopWebApp.Interfaces;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Services
{
	public class InMemoryCategoriesService : ICategoriesService
    {
        private static uint instanceCounter = 1;

        private static readonly List<ProductCategory> _categories =
		[
			new ProductCategory(instanceCounter++, "Корм", "Товары для питания животных - лакомства, ветеринарные корма, ",""),
			new ProductCategory(instanceCounter++, "Аксессуары", "Принадлежности для питания, выгула, одежда для животных, уходовая косметика", ""),
			new ProductCategory(instanceCounter++, "Мебель", "Клетки, лежаки, домики", ""),
			new ProductCategory(instanceCounter++, "Переноски", "Товары для перемещения животных", ""),
			new ProductCategory(instanceCounter++, "Игрушки", "Товары для игр и развлечений", ""),
			new ProductCategory(instanceCounter++, "Книги", "Книги, журналы, инструкции по уходу за животными", ""),
			new ProductCategory(instanceCounter++, "ВетАптека", "Медицинские товары, лекарства для животных", "")
		];

		public List<ProductCategory> GetAll() => _categories;

		public ProductCategory? TryGetById(uint id) => _categories.FirstOrDefault(x => x.Id == id);
	}
}
