using ECommerce.Dtos.Request.Create;
using ECommerce.Dtos.Request.Update;
using ECommerce.Dtos.Response;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	[ApiController]
	[Route("api/users")]
	public class ClientController(ClientService _service) : ControllerBase
	{

		[HttpGet]
		public ActionResult<List<ResponseWand>> GetAllClients(long id)
		{
			var response = _service.GetAllClients();
			return Ok(response);
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<ResponseWand> CreateClient(CreateClientRequest request)
		{
			var response = _service.CreateClient(request);
			return Ok(response);
		}

		[HttpPut("{id:long}")]
		public ActionResult<ResponseWand> UpdateClient(long id, UpdateClientRequest request)
		{
			var response = _service.UpdateClient(id, request);
			return Ok(response);
		}

		[HttpGet("{id:long}")]
		public ActionResult<ResponseWand> GetClientById(long id)
		{
			var response = _service.GetClient(id);
			return Ok(response);
		}

		[HttpDelete("{id:long}")]
		public ActionResult DeleteClient(long id)
		{
			_service.DeleteClient(id);
			return NoContent();
		}
	}
}
