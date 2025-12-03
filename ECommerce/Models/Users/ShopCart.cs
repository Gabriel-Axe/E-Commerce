namespace ECommerce.Models
{
	public sealed class ShopCart
	{
		public Client owner { get; }
		public List<Product> products { get; }
	}
}
