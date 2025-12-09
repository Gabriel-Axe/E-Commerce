using ECommerce.Data;
using ECommerce.Dtos;
using ECommerce.Dtos.Response;
using ECommerce.Models;

using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	[ApiController]
	[Route("api/users")]
	public class UserController(ECommerceDbContext db, ILogger<UserController> logger) : ControllerBase
	{
		private readonly ECommerceDbContext _db = db;
		private readonly ILogger<UserController> _logger = logger;
	}
}
