using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	[ApiController]
	[Route("api/ping")]
	public class FrontendPingController : ControllerBase
	{

		[HttpGet]
		public void RespondPing()
		{
			Console.WriteLine("Pong");
		}
	}
}
