using ECommerce.Models;

namespace ECommerce.Dtos.Response.User
{
	public record ProductInfo(long id, ECommerce.Models.Shop origin)
	{
		public ProductInfo(Product product) : this(product.id, product.origin) { }
	}
}
