using ECommerce.Dtos.Request.create;
using ECommerce.Dtos.Request.Update;
using ECommerce.Dtos.Response;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	[ApiController]
	[Route("api/products")]
	public class ProductController(ILogger<ShopController> _logger, ProductService _service) : ControllerBase
	{
		[HttpGet]
		public ActionResult<ResponseUser> CreateUser(CreateProductRequest request)
		{
			var response = _service.CreateProduct(request);
			return Ok(response);
		}

		[HttpPut("{id:long}")]
		public ActionResult<ResponseUser> UpdateUser(long id, UpdateProductRequest request)
		{
			var response = _service.UpdateProduct(id, request);
			return Ok(response);
		}

		public ActionResult<ResponseUser> GetUserById(long id)
		{
			var response = _service.GetProduct(id);
			return Ok(response);
		}

		public ActionResult DeleteUser(long id)
		{
			_service.DeleteProduct(id);
			return NoContent();
		}
	}
}
