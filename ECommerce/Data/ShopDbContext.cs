using ECommerce.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ECommerce.Data
{
	public class ShopContext : DbContext
	{
		public DbSet<Shop> Shops { get; set; }

		public ShopContext(DbContextOptions<ShopContext> dbContext) : base(dbContext) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// optionsBuilder.UseSqlServer(
			// "Server=db;User Id=sa; Password=YourStrong!Passw0rd;Database=Blogging;Trusted_Connection=True;ConnectRetryCount=0");
		}
	}
}
