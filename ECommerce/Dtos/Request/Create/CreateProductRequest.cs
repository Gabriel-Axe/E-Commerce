namespace ECommerce.Dtos.Request.create
{
	public record CreateProductRequest(string Name, long ShopId, string? Description);
}
