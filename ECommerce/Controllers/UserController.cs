using ECommerce.Dtos.Request.Create;
using ECommerce.Dtos.Request.Update;
using ECommerce.Dtos.Response;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	[ApiController]
	[Route("api/users")]
	public class UserController(ILogger<UserController> _logger, UserService _service) : ControllerBase
	{
		[HttpGet]
		public ActionResult<ResponseUser> CreateUser(CreateUserRequest request)
		{
			var response = _service.CreateUser(request);
			return Ok(response);
		}

		[HttpPut("{id:long}")]
		public ActionResult<ResponseUser> UpdateUser(long id, UpdateUserRequest request)
		{
			var response = _service.UpdateUser(id, request);
			return Ok(response);
		}

		public ActionResult<ResponseUser> GetUserById(long id)
		{
			var response = _service.GetUser(id);
			return Ok(response);
		}

		public ActionResult DeleteUser(long id)
		{
			_service.DeleteUser(id);
			return NoContent();
		}
	}
}
