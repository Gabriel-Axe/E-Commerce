using ECommerce.Models;

namespace ECommerce.Dtos
{
	public record CreateUserRequest(string username, User.UserType type);
}
