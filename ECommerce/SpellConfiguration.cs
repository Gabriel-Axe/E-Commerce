using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data
{
	public class SpellConfiguration : IEntityTypeConfiguration<Spell>
	{
		public void Configure(EntityTypeBuilder<Spell> builder)
		{
			builder.HasData(
					new
					{
						Id = 1,
						Name = "Firebal",
						Description = "Explosive projectile"
					}
				);
		}
	}
}
