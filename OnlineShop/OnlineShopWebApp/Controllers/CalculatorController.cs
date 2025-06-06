using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
	public class CalculatorController : Controller
	{
		private readonly string[] signs = ["+", "-", "*"]; 

		public string Index(double num1, double num2, string sign)
		{
			if (sign.Length >= 2 || !signs.Contains(sign))
			{
				return  $"Недопустимая операция!\nВ последнем сегменте может быть указан только один знак арифметической операции.\nДопустимые варианты символов: +, - , *";
			}

			switch (sign)
			{
				case "-":
					return $"{num1} {sign} {num2} = {num1 - num2}";

				case "*":
					return $"{num1} {sign} {num2} = {num1 * num2}";

				default:
					return $"{num1} {sign} {num2} = {num1 + num2}";
			}
		}
	}
}
