using ECommerce.Models;

namespace ECommerce.Dtos.Request.Update
{
	public record UpdateShopRequest(string? Name, string? Description, List<Product?>? Products);
}
