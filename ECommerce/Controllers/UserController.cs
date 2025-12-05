using ECommerce.Dtos;
using ECommerce.Models;
using ECommerce.Services;


using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	// FIXME: get a better name for these controllers
	// [ApiController]
	[Controller]
	[Route("api/user")]
	public class UserController : ControllerBase
	{
		// private readonly UserServices services;
		private readonly UserContext _db;
		// private readonly ILogger<UserActionsController> _logger;

		// [HttpPost]
		// public ActionResult<User> CreateUser(CreateUserRequest request)
		// {
		// 	// this._logger.LogInformation("Creating user");
		// 	var user = this.services.CreateUser(request);
		// 	// this._logger.LogInformation("Created user");
		// 	return Ok(user);
		// }
		public UserController(UserContext dbContext)
		{
			this._db = dbContext;
		}

		[HttpPost]
		public ActionResult<User> CreateUser(CreateUserRequest request)
		{
			var user = new User(request);
			return Ok(user);
		}

		[HttpGet]
		public ActionResult<List<User>> GetAllUsers()
		{
			var users = from user in this._db.Users
									select user;
			return users.ToList();
		}

		[HttpGet("greet")]
		public String Greet(CreateUserRequest request)
		{
			return "lmao";
		}
	}
}
