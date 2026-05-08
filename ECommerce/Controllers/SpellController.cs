using System.Collections.Immutable;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	[ApiController]
	[Route("api/spells")]
	public class SpellController(ECommerceDbContext _db) : ControllerBase
	{
		[HttpGet]
		public ActionResult<List<Spell>> GetAllSpells()
		{
			var allSpells = _db.Spells;
			return allSpells.ToList();
		}
	}
}
