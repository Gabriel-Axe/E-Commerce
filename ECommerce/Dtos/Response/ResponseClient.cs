using ECommerce.Models;

namespace ECommerce.Dtos.Response
{
	public record ResponseClient(long Id, string Name, string Email, string Telephone)
	{
		public ResponseClient(Client client) : this(client.Id, client.Name, client.Email, client.Telephone) { }
	}

}
