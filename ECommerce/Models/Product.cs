using ECommerce.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models
{
	[PrimaryKey(nameof(id))]
	public sealed class Product
	{
		// FIXME: Change all ids int to ids long
		public long id { get; private set; }
		public string name { get; private set; }
		public Shop origin { get; private set; }

		public Product() { }

		public Product(string name, Shop origin)
		{
			this.name = name;
			this.origin = origin;
		}

		public Product(CreateProductRequest request)
		{
			this.name = request.username;
			this.origin = request.origin;
		}
	}
}
