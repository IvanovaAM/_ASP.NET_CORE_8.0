using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
	public class CalculatorController : Controller
	{
		public string Index(double num1, double num2)
		{
			return $"{num1} + {num2} = {num1 + num2}";
		}
	}
}
