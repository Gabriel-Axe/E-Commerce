using System.ComponentModel.DataAnnotations;
using ECommerce.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models.Shop
{
	[PrimaryKey(nameof(Id))]
	public sealed class Shop(long Id, string Name)
	{
		public long Id { get; set; } = Id;
		public string Name { get; set; } = Name;
		public List<Product> Prodcts { get; set; } = new();
	}
}
