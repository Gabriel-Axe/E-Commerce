using ECommerce.Dtos.Request.create;

namespace ECommerce.Models
{
	public sealed class Product
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public long ShopId { get; set; }

#pragma warning disable CS8618
		public Product() { }

		public Product(long id, string name, long shopId, string? description)
		{
			Id = id;
			Name = name;
			ShopId = shopId;
			Description = description;
		}

		public Product(CreateProductRequest request)
		{
			Name = request.Name;
			ShopId = request.ShopId;
			Description = request.Description;
		}

		public void Update(string? name, string? description)
		{
			if (!string.IsNullOrWhiteSpace(name))
			{
				Name = name;
			}
			if (!string.IsNullOrWhiteSpace(description))
			{
				Description = description;
			}
		}
	}
}
