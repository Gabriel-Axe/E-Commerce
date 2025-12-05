using System.ComponentModel.DataAnnotations;
using ECommerce.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ECommerce.Models
{
	// FIXME: THIS WAS SUPOSED TO BE A ABSTRACT CLASS
	[PrimaryKey(nameof(UserId))]
	public class User
	{
		[Key]
		public int UserId { get; private set; }
		public UserType UType { get; private set; }
		public string Username { get; private set; } // WARN: Idk why but making it private removed both the nullability issue and the "cant have atribute less acessible then setter" issue

		public User() { }

		public User(CreateUserRequest request) : this(request.username, request.type) { }

		public User(string name, UserType type)
		{
			// this.UType = request.type;
			this.Username = name;
			this.UType = type;
		}

		public enum UserType
		{
			CLIENT,
			SHOP_OWNER
		}
	}
}
