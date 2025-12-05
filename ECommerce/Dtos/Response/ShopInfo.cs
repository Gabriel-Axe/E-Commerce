using ECommerce.Models;

namespace ECommerce.Dtos.Response
{
	public record ShopInfo(long Id, string name, List<Product>? Products)
	{
		public ShopInfo(Shop shop) : this(shop.Id, shop.Name, shop.Prodcts) { }
	}
}
