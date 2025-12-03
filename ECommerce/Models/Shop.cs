namespace ECommerce.Models
{
	public sealed class Shop
	{
		public int Id { get; }
		public string Name { get; }
		public Dictionary<Product, int> Prodcts { get; }

		// FIXME: 
		// > Should not be held in memory
		// > Should be created proper structure to hold this
		public List<int> reviews { get; init; }


	}
}
