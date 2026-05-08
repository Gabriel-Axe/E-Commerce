using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
	[Table("Wands")]
	public abstract class Wand
	{
		public int Id { get; set; }

#pragma warning disable CS8618
		public Wand() { }

	}
}
