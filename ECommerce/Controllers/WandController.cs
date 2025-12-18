using ECommerce.Dtos.Request.create;
using ECommerce.Dtos.Request.Update;
using ECommerce.Dtos.Response;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	[ApiController]
	// [Route("api/products")]
	[Route("[controller]")]
	public class WandController(WandService _service) : ControllerBase
	{
		[HttpGet]
		public ActionResult<ResponseWand> CreateClient(CreateWandRequest request)
		{
			var response = _service.CreateWand(request);
			return Ok(response);
		}

		[HttpPut("{id:long}")]
		public ActionResult<ResponseWand> UpdateClient(long id, UpdateWandRequest request)
		{
			var response = _service.UpdateWand(id, request);
			return Ok(response);
		}

		public ActionResult<ResponseWand> GetClientById(long id)
		{
			var response = _service.GetWand(id);
			return Ok(response);
		}

		public ActionResult DeleteClient(long id)
		{
			_service.DeleteWand(id);
			return NoContent();
		}
	}
}
