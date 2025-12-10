using ECommerce.Models;

namespace ECommerce.Dtos.Request.Create
{
	public record CreateShopRequest(long OwnerId, string Name, string? Description, List<Product?> Products);
}
