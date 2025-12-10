using Microsoft.AspNetCore.Mvc;

using ECommerce.Services;
using ECommerce.Dtos.Request.Create;
using ECommerce.Dtos.Request.Update;
using ECommerce.Dtos.Response;

namespace ECommerce.Controllers
{

	[ApiController]
	[Route("api/shops")]
	public class ShopController(ILogger<ShopController> _logger, ShopService _service) : ControllerBase
	{
		[HttpGet]
		public ActionResult<ResponseProduct> CreateShop(CreateShopRequest request)
		{
			var response = _service.CreateShop(request);
			return Ok(response);
		}

		[HttpPut("{id:long}")]
		public ActionResult<ResponseProduct> UpdateShop(long id, UpdateShopRequest request)
		{
			var response = _service.UpdateShop(id, request);
			return Ok(response);
		}

		public ActionResult<ResponseProduct> GetShopById(long id)
		{
			var response = _service.GetShop(id);
			return Ok(response);
		}

		public ActionResult DeleteShop(long id)
		{
			_service.DeleteShop(id);
			return NoContent();
		}
	}
}
