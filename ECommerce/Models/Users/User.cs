using Microsoft.Extensions.Logging;

namespace ECommerce.Models
{
	public abstract class User
	{
		public int UserId { get; }
		public string Username { get; }
	}
}
