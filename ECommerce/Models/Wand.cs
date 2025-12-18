using System.ComponentModel.DataAnnotations.Schema;
using ECommerce.Dtos.Request.create;

namespace ECommerce.Models
{
	[Table("Wands")]
	public sealed class Wand
	{
		public long Id { get; set; }
		public int Slots { get; set; }
		public Spell[] Spells { get; set; }

#pragma warning disable CS8618
		public Wand() { }

		public Wand(long id, int slots)
		{
			Id = id;
			Slots = slots;
			Spells = new Spell[slots];
		}

		public Wand(CreateWandRequest request)
		{
		}

		public void Update()
		{
		}
	}
}
