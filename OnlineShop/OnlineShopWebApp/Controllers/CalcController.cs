using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
	public class CalcController : Controller
	{
		public string Index(double a=0, double b=0, string c="+")
		{
			if (c.Length >= 2 || !c.Contains(c))
			{
				return $"Недопустимая операция!\nВ последнем сегменте может быть указан только один знак арифметической операции.\nДопустимые варианты символов: +, - , *";
			}

			switch (c)
			{
				case "-":
					return $"{a} {c} {b} = {a - b}";

				case "*":
					return $"{a} {c} {b} = {a * b}";

				case "/":
					return (b != 0) ? $"{a} {c} {b} = {a / b}" : $"На ноль делить нельзя! Введите другое значение параметра b";

				default:
					return $"{a} {c} {b} = {a + b}";
			}
		}
	}
}
