// using ECommerce.Models;
//
// using Microsoft.AspNetCore.Mvc;
//
// namespace ECommerce.Controllers
// {
// 	// FIXME: get a better name for these controllers
// 	[ApiController]
// 	[Route("/api/user-actions")]
// 	public class UserActionsController : ControllerBase
// 	{

// 	private readonly ILogger<UserActionsController> _logger;
// 	// private readonly InMemoryDb<Product> productsDb;
// 	// private readonly InMemoryDb<Client> clientsDb;
//
// 	public ActionResult InsertProductToShopCart(long clientId, long id)
// 	{
//
// 		// // FIXME: Inneficient (prob)
// 		// var product = this.productsDb.ObjectsInMemory.Find(pr => pr.id == id);
// 		//
// 		// this.clientsDb.ObjectsInMemory.Find(cl => cl.UserId == clientId).shoppingCart.products.Add(product);
// 		//
// 		return NoContent();
// 	}
//
// 	public ActionResult RemoveProductFromShopCart(long clientId, long id)
// 	{
// 		// // FIXME: Inneficient (prob)
// 		// var product = this.productsDb.ObjectsInMemory.Find(pr => pr.id == id);
// 		// this.clientsDb.ObjectsInMemory.Find(cl => cl.UserId == clientId).shoppingCart.products.Remove(product);
// 		//
// 		return NoContent();
// 	}
//
// 	// public ActionResult<ShopCart> GetShopCart(long clientId)
// 	// {
// 	//
// 	// 	// // FIXME: Inneficient (prob)
// 	// 	// return Ok(this.clientsDb.ObjectsInMemory.Find(cl => cl.UserId == clientId).shoppingCart);
// 	// }
// }
// }

