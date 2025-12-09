using ECommerce.Dtos.Request.Update;

namespace ECommerce.Models.Shop
{
	public sealed class Product(long Id, string Name)
	{
		public long Id { get; private set; } = Id;
		public string Name { get; set; } = Name;
	}
}
