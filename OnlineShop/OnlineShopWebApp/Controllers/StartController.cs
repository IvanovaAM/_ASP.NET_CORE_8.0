using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
	public class StartController : Controller
	{
		private string[] message = ["Доброе утро", "Добрый день", "Добрый вечер", "Доброй ночи"];

		public string Hello()
		{
			var timeNow = DateTime.Now.TimeOfDay;

			if (timeNow >= new TimeSpan(0, 0, 0) && timeNow <= new TimeSpan(5, 59, 0))
			{
				return message[0];
			}

			if (timeNow >= new TimeSpan(6, 0, 0) && timeNow <= new TimeSpan(11, 59, 0))
			{
				return message[1];
			}

			if (timeNow >= new TimeSpan(12, 0, 0) && timeNow <= new TimeSpan(17, 59, 0))
			{
				return message[2];
			}			
			
			return message[3];			
		}
	}
}
