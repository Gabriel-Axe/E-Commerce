using ECommerce.Models;

namespace ECommerce.Dtos.Response
{
	public record ResponseUser(long Id, string Name, string Email, string Telephone)
	{
		public ResponseUser(User user) : this(user.Id, user.Name, user.Email, user.Telephone) { }
	}

}
