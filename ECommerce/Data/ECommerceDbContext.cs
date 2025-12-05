using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
	public class ECommerceDbContext : DbContext
	{
		public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }

		public DbSet<User> Users { get; }
		public DbSet<Shop> Shops { get; }
		public DbSet<Product> Products { get; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().ToTable("Users");
			modelBuilder.Entity<Shop>().ToTable("Shops");
			modelBuilder.Entity<Product>().ToTable("Products");
		}
	}
}
