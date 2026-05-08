using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce
{
	public class ECommerceDbContext : DbContext
	{
		public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }

		public DbSet<Client> Clients { get; set; }
		public DbSet<Spell> Wands { get; set; }
		public DbSet<Spell> Spells { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Spell>()
				.HasDiscriminator<string>("spell_type")
				.HasValue<Projectile>("projectile")
				.HasValue<Modifier>("modifier");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// optionsBuilder.UseSqlite("TestDb");
			optionsBuilder.UseInMemoryDatabase("TestDb");
		}
	}
}
