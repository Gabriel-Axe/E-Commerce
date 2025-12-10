using ECommerce.Dtos.Request.Create;

namespace ECommerce.Models
{
	public sealed class Shop
	{

#pragma warning disable CS8618
		public Shop() { }

		public long Id { get; set; }
		public long OwnerId { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public List<Product?> Products { get; set; }

		public Shop(long ownerId, string name, string? description, List<Product?> products)
		{
			OwnerId = ownerId;
			Name = name;
			Description = description;
			Products = products;
		}

		public Shop(CreateShopRequest request)
		{
			OwnerId = request.OwnerId;
			Name = request.Name;
			Description = request.Description;
			Products = request.Products;
		}

		public void Update(string? name, string? description, List<Product?>? products)
		{
			if (!string.IsNullOrWhiteSpace(name))
			{
				Name = name;
			}
			if (!string.IsNullOrWhiteSpace(description))
			{
				Description = description;
			}
			if (products is not null)
			{
				Products = products;
			}
		}
	}
}
