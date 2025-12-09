using Microsoft.AspNetCore.Mvc;

using ECommerce.Data;
using ECommerce.Services;

namespace ECommerce.Controllers
{

	[ApiController]
	[Route("api/shops")]
	public class ShopController(ECommerceDbContext db, ILogger<ShopController> logger, ShopServices services) : ControllerBase
	{

		private readonly ECommerceDbContext _db = db;
		private readonly ILogger<ShopController> _logger = logger;
		private readonly ShopServices services = services;

	}
}
