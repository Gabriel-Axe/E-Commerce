using ECommerce.Models;

namespace ECommerce.Dtos.Response
{
	public record ResponseShop(long OwnerId, string Name, string? Description, List<Product?> Products)
	{
		public ResponseShop(Shop shop) : this(shop.OwnerId, shop.Name, shop.Description, shop.Products) { }
	}
}
