using System.ComponentModel.DataAnnotations;
using System.Numerics;
using ECommerce.Dtos;
using ECommerce.Dtos.Request;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models
{
	[PrimaryKey(nameof(Id))]
	public sealed class Shop
	{
		[Key]
		public long Id { get; private set; }
		public string Name { get; private set; }
		public List<Product> Prodcts { get; } = new();

		// FIXME: 
		// > Should not be held in memory
		// > Should be created proper structure to hold this
		public List<int> reviews { get; } = new();

		public Shop() { }

		public Shop(CreateShop request) : this(request.name) { }

		public Shop(string name) { this.Name = name; }
	}
}
