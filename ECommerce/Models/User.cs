using ECommerce.Dtos.Request.Create;

namespace ECommerce.Models
{
	public class User
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Telephone { get; set; }
		public string PasswordHash { get; set; }

#pragma warning disable CS8618
		public User() { }

		public User(long id, string name, string email, string telephone, string passwordHash)
		{
			Id = id;
			Name = name;
			Email = email;
			Telephone = telephone;
			PasswordHash = passwordHash;
		}

		public User(CreateUserRequest request)
		{
			Name = request.Name;
			Email = request.Email;
			Telephone = request.Telephone;
			PasswordHash = request.Password;
		}

		public void Update(string? name, string? email, string? telephone)
		{
			if (!string.IsNullOrWhiteSpace(name))
			{
				Name = name;
			}
			if (!string.IsNullOrWhiteSpace(email))
			{
				Email = email;
			}
			if (!string.IsNullOrWhiteSpace(telephone))
			{
				Telephone = telephone;
			}
		}
	}
}
