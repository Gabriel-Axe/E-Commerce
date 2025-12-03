namespace ECommerce.Models
{
	public sealed class Product
	{
		// FIXME: Change all ids int to ids long
		public long id { get;}
		public string name { get; }
		public Shop origin { get; }
	}
}
