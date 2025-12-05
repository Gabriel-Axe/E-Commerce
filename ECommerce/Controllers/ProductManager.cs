		// [HttpPost]
		// // WARN: Not sure (right now) if i need to put `async` in here
		// // FIXME: Should use DTO instead of raw `Product`
		// public async Task<IActionResult> CreateProduct(Product product)
		// {
		// 	this.productsDb.ObjectsInMemory.Add(product);
		//
		// 	return Ok(product);
		// }
		//
		// public async Task<IActionResult> GetProductOfId(long id)
		// {
		// 	var product = from prod in this.productsDb.ObjectsInMemory
		// 								where (prod.id == id)
		// 								select prod;
		//
		// 	return Ok(product);
		// }
