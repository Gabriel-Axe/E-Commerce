using Microsoft.AspNetCore.Mvc;

using ECommerce.Models;
using ECommerce.Dtos;
using ECommerce.Services;
using ECommerce.Data;
using ECommerce.Dtos.Response;
using ECommerce.Dtos.Request;

namespace ECommerce.Controllers
{

	[ApiController]
	[Route("api/shop-management")]
	public class ShopManagementController : ControllerBase
	{

		private readonly ShopContext _db;
		// private readonly ILogger<ShopManagementController> _logger;
		// private InMemoryDb<Product> productsDb;
		// private readonly ShopServices services;

		public ShopManagementController(ShopContext db)
		{
			this._db = db;
			this._db.Database.EnsureCreated();
		}

		// [HttpGet("/{id}")]
		// public ActionResult<ShopInfo> FindShopWithId(long shopId)
		// [HttpGet("{id:long}")]
		// [Route("Home/About/{id}")]
		[HttpGet("{id}")]
		public ActionResult FindShopWithId(long id)
		{
			// using var shopDb = new ShopContext();
			var found_shop = from shopRecord in this._db.Shops
											 where shopRecord.Id == id
											 select shopRecord;
			var shop = found_shop.First();

			// return Ok(new ShopInfo(shop));
			return Ok("Hello");
		}

		[HttpPost]
		public ActionResult<ShopInfo> CreateShop(CreateShop request)
		{
			// using var db = new ShopContext();
			var newShop = new Shop(name: request.name);
			this._db.Add(newShop);
			this._db.SaveChanges();

			return Ok(new ShopInfo(newShop));
		}

		// [HttpGet]
		// public ActionResult<List<ShopInfo>> GetAllShops()
		// {
		// 	var shopList = from shopRecord in this._db.Shops
		// 								 select shopRecord;
		//
		// 	return Ok(shopList.ToList());
		// }

		[HttpDelete("{id}")]
		public ActionResult DeleteShop(long id)
		{
			// using var db = new ShopContext();
			var found_shop = from shopRecord in this._db.Shops
											 where shopRecord.Id == id
											 select shopRecord;
			var shop = found_shop.First();
			this._db.Remove(shop);
			this._db.SaveChanges();

			return Ok(new ShopInfo(shop));
		}

		// public ShopManagementController(ILogger<ShopManagementController> logger, InMemoryDb<Product> productsDb)
		// {
		// 	this._logger = logger;
		// 	this.productsDb = productsDb;
		// }
	}
}
