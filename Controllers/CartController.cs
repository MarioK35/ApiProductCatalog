using BooksApi.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
      private readonly CartService _cartService;

         public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

         [HttpGet]
        public ActionResult<List<Cart>> Get() =>
            _cartService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCart")]
        public ActionResult<Cart> Get(string id)
        {
            var cart = _cartService.Get(id);

            if (cart == null)
            {
                return NotFound();
            }

            return cart;
        }

       

        [HttpPost]
        public ActionResult<Cart> Create(Cart cart)
        {
            _cartService.Create(cart);

            return CreatedAtRoute("GetCart", new { id = cart.Id.ToString() }, cart);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Cart cartIn)
        {
            var cart = _cartService.Get(id);

            if (cart == null)
            {
                return NotFound();
            }

            _cartService.Update(id, cartIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var cart = _cartService.Get(id);

            if (cart == null)
            {
                return NotFound();
            }

            _cartService.Remove(cart.Id);

            return NoContent();
        }






    }
}