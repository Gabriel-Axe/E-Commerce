using ECommerce.Dtos;
using ECommerce.Models;

using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly UserContext _db;
		private readonly ILogger<UserController> _logger;

		public UserController(UserContext db, ILogger<UserController> logger)
		{
			this._logger = logger;
			this._db = db;
			this._db.Database.EnsureCreated();
		}

		public UserController(UserContext dbContext)
		{
			this._db = dbContext;
		}

		[HttpGet]
		public ActionResult<List<User>> GetAllUsers()
		{
			var users = from user in this._db.Users
									select user;
			return users.ToList();
		}
	}
}
