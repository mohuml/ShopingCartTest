using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShppingCart.Models;

namespace ShppingCart.Controllers
{
    public class CartItemsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // Get: CartItems/GetAll
        [HttpGet]
        public List<CartItem> GetAll()
        {
                var all_cart_items = db.CartItem.ToList();

                return all_cart_items;
        }

        // Get: CartItems/Details/2
        [HttpGet]
        public CartItem Details(string CartId)
        {
            var cart_item = db.CartItem.Find(CartId);

            return cart_item;
        }

        // Get: CartItems/GetTotal - Her get total price of Shopping Cart items
        [HttpGet]
        public Double GetTotal()
        {
            var all_cart_items = db.CartItem.ToList();
            double total = 0.0;
            foreach (var item in all_cart_items)
            {
                total += item.Quantity * item.Product.price;
            }

            return total;
        }

        // POST: CartItems/Add
        [HttpPost]
        public string Add(Product product, int Quantity)
        {
            try
            {
                CartItem add_item = new CartItem();
                add_item.ProductId = product.id;
                add_item.DateCreated = DateTime.Now;
                add_item.Quantity = Quantity;
                add_item.CartId = Guid.NewGuid().ToString();


                db.CartItem.Add(add_item);

                return "Product Added Successfull!!";
            }
            catch
            {
                return "Try Again!!";
            }
        }

        // POST: CartItems/Delete/5 - Here delete item in Cart
        [HttpPost]
        public string Delete(string CartId , Product product)
        {
            try
            {
                CartItem delete_item = db.CartItem.Find(CartId);
                db.CartItem.Remove(delete_item);
                return "Product deleted Successfully!!";
            }
            catch
            {
                return "This item not exist";
            }
        }
    }
}
