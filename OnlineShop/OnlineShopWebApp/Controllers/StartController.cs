using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
	public class StartController : Controller
	{
		private string[] message = ["Доброй ночи", "Доброе утро", "Добрый день", "Добрый вечер"];

		public string Hello()
		{
			var timeNow = DateTime.Now.Hour;

			if (timeNow < 6)
			{
				return message[0];
			}

			if (timeNow < 12)
			{
				return message[1];
			}

			if (timeNow < 18)
			{
				return message[2];
			}			
			
			return message[3];			
		}
	}
}
