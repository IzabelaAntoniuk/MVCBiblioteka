using MVCBiblioteka.Models;
using MVCBiblioteka.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBiblioteka.Controllers
{
    public class BooksCartController : Controller
    {
        ApplicationDbContext storeDB = new ApplicationDbContext();
        //
        // GET: /ShoppingCart/
        public ActionResult Index()
        {
            var cart = BooksCart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new BooksCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };
            // Return the view
            return View(viewModel);
        }
        //
        // GET: /Store/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            // Retrieve the album from the database
            var addedBook = storeDB.Books
                .Single(book => book.BookID == id);

            // Add it to the shopping cart
            var cart = BooksCart.GetCart(this.HttpContext);

            cart.AddToCart(addedBook);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }
        //
        // AJAX: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = BooksCart.GetCart(this.HttpContext);

            // Get the name of the album to display confirmation
            string bookName = storeDB.Carts.Single(item => item.RecordID == id).Book.title;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new BooksCartRemoveViewModel
            {
                Message = Server.HtmlEncode(bookName) +
                    " - usunięto z koszyka.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }
        //
        // GET: /ShoppingCart/CartSummary
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = BooksCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }
    }
}