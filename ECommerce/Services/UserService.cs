using ECommerce.Data;
using ECommerce.Dtos.Request.Create;
using ECommerce.Dtos.Response;
using ECommerce.Models;
using ECommerce.Dtos.Request.Update;

namespace ECommerce.Services
{
	public class UserService(ECommerceDbContext _db)
	{

		public ResponseUser CreateUser(CreateUserRequest request)
		{
			var user = new User(request);
			_db.Users.Add(user);
			_db.SaveChanges();

			return new ResponseUser(user);
		}

		public ResponseUser UpdateUser(long userId, UpdateUserRequest request)
		{

			var user = _db.Users.FirstOrDefault(u => u.Id == userId)
				?? throw new Exception($"User with ID {userId} not found");

			user.Update(request.Name, request.Email, request.Telephone);
			_db.SaveChanges();

			return new ResponseUser(user);
		}

		public ResponseUser GetUser(long userId)
		{
			var user = _db.Users.FirstOrDefault(u => u.Id == userId)
				?? throw new Exception($"User with ID {userId} not found");

			return new ResponseUser(user);
		}

		public void DeleteUser(long userId)
		{
			var user = _db.Users.FirstOrDefault(u => u.Id == userId)
				?? throw new Exception($"User with ID {userId} not found");

			_db.Users.Remove(user);
			_db.SaveChanges();
		}
	}
}
