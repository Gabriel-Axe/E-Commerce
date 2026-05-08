using ECommerce.Dtos.Request.Create;
using ECommerce.Dtos.Response;
using ECommerce.Models;
using ECommerce.Dtos.Request.Update;

namespace ECommerce.Services
{
	public class ClientService(ECommerceDbContext _db)
	{

		public List<ResponseClient> GetAllClients()
		{
			var userList = _db.Clients.ToList();
			var returnList = userList.ConvertAll(new Converter<Client, ResponseClient>(ClientToResponse));

			return returnList;
		}

		public static ResponseClient ClientToResponse(Client u)
		{
			return new ResponseClient(u);
		}

		public ResponseClient CreateClient(CreateClientRequest request)
		{
			var user = new Client(request);
			_db.Clients.Add(user);
			_db.SaveChanges();

			return new ResponseClient(user);
		}

		public ResponseClient UpdateClient(long userId, UpdateClientRequest request)
		{

			var user = _db.Clients.FirstOrDefault(u => u.Id == userId)
				?? throw new Exception($"Client with ID {userId} not found");

			user.Update(request.Name, request.Email, request.Telephone);
			_db.SaveChanges();

			return new ResponseClient(user);
		}

		public ResponseClient GetClient(long userId)
		{
			var user = _db.Clients.FirstOrDefault(u => u.Id == userId)
				?? throw new Exception($"Client with ID {userId} not found");

			return new ResponseClient(user);
		}

		public void DeleteClient(long userId)
		{
			var user = _db.Clients.FirstOrDefault(u => u.Id == userId)
				?? throw new Exception($"Client with ID {userId} not found");

			_db.Clients.Remove(user);
			_db.SaveChanges();
		}
	}
}
