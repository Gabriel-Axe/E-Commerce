using ECommerce.Models;

namespace ECommerce.Dtos.Response
{
	public record ResponseWand(long Id)
	{
		public ResponseWand(Wand wand) : this(wand.Id) { }
	}
}
