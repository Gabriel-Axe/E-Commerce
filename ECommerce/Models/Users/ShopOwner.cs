namespace ECommerce.Models
{
	public sealed class ShopOwner : User
	{
		public List<Shop> Shops { get; }
	}
}

