using ECommerce.Data;
using ECommerce.Dtos.Request.create;
using ECommerce.Dtos.Request.Update;
using ECommerce.Dtos.Response;
using ECommerce.Models;

namespace ECommerce.Services
{
	public class ProductService(ECommerceDbContext _db)
	{
		public ResponseProduct CreateProduct(CreateProductRequest request)
		{
			var product = new Product(request);
			_db.Products.Add(product);
			_db.SaveChanges();

			return new ResponseProduct(product);
		}

		public ResponseProduct UpdateProduct(long userId, UpdateProductRequest request)
		{

			var product = _db.Products.FirstOrDefault(u => u.Id == userId)
				?? throw new Exception($"Product with ID {userId} not found");

			product.Update(request.Name, request.Description);
			_db.SaveChanges();

			return new ResponseProduct(product);
		}

		public ResponseProduct GetProduct(long shopId)
		{
			var product = _db.Products.FirstOrDefault(s => s.Id == shopId)
				?? throw new Exception($"Product with ID {shopId} not found");

			return new ResponseProduct(product);
		}

		public void DeleteProduct(long shopId)
		{
			var product = _db.Products.FirstOrDefault(s => s.Id == shopId) ?? throw new Exception($"Product with ID {shopId} not found");

			_db.Products.Remove(product);
			_db.SaveChanges();
		}
	}
}
