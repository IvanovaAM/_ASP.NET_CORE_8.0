using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
	public class CalculatorController : Controller
	{
		public string Index(double num1, double num2, char sign)
		{
			switch(sign)
			{
				case '+':
					return $"{num1} {sign} {num2} = {num1 + num2}";
				case '-':
					return $"{num1} {sign} {num2} = {num1 - num2}";
				case '*':
					return $"{num1} {sign} {num2} = {num1 * num2}";
				default:
					return $"Недопустимая операция!";
			}
			
		}
	}
}
