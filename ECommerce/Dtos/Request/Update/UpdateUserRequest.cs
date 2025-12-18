namespace ECommerce.Dtos.Request.Update
{
	public record UpdateUserRequest(string? Name, string? Email, string? Telephone, string? Password);
}
