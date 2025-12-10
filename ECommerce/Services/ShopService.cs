using ECommerce.Data;
using ECommerce.Dtos.Request.Create;
using ECommerce.Dtos.Request.Update;
using ECommerce.Dtos.Response;
using ECommerce.Models;

namespace ECommerce.Services
{
	public class ShopService(ECommerceDbContext _db)
	{

		public ResponseShop CreateShop(CreateShopRequest request)
		{
			var shop = new Shop(request);
			_db.Shops.Add(shop);
			_db.SaveChanges();

			return new ResponseShop(shop);
		}

		public ResponseShop UpdateShop(long userId, UpdateShopRequest request)
		{

			var shop = _db.Shops.FirstOrDefault(u => u.Id == userId)
				?? throw new Exception($"Shop with ID {userId} not found");

			shop.Update(request.Name, request.Description, request.Products);
			_db.SaveChanges();

			return new ResponseShop(shop);
		}

		public ResponseShop GetShop(long shopId)
		{
			var shop = _db.Shops.FirstOrDefault(s => s.Id == shopId)
				?? throw new Exception($"Shop with ID {shopId} not found");

			return new ResponseShop(shop);
		}

		public void DeleteShop(long shopId)
		{
			var shop = _db.Shops.FirstOrDefault(s => s.Id == shopId) ??
				 throw new Exception($"Shop with ID {shopId} not found");

			_db.Shops.Remove(shop);
			_db.SaveChanges();
		}
	}
}
