using ECommerce.Models;

namespace ECommerce.Dtos
{
	public record CreateProductRequest(string username, Shop origin);
}
