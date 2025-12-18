using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
	[Table("Spells")]
	public abstract class Spell
	{
		public int Id { get; set; }
		public string Name { get; init; }
		public string Description { get; set; }

#pragma warning disable CS8618
		public Spell() { }

		public Spell(string name, string description)
		{
			Name = name;
			Description = description;
		}
	}
}
