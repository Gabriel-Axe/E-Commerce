using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
	public class ECommerceDbContext : DbContext
	{
		public ECommerceDbContext(DbContextOptions<DbContext> options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Shop> Shops { get; set; }
		public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
					modelBuilder.Entity<User>().ToTable("Users");
					modelBuilder.Entity<Shop>().ToTable("Shops");
					modelBuilder.Entity<Product>().ToTable("Products");
        }
	}
}
