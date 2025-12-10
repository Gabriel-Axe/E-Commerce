using ECommerce.Models;

namespace ECommerce.Dtos.Response
{
	public record ResponseProduct(long Id, string Name, long ShopId, string? Description)
	{
		public ResponseProduct(Product product) : this(product.Id, product.Name, product.ShopId, product.Description) { }
	}
}
