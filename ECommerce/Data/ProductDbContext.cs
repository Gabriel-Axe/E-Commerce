using ECommerce.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ECommerce
{
	public class ProductContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
					@"Server=(http://localhost:1433)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;ConnectRetryCount=0");
		}
	}
}
