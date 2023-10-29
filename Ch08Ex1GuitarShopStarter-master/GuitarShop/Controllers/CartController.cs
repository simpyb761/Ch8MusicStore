using GuitarShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string id)
        {
            TempData["message"] = "Item has been added to your cart";
            return RedirectToAction("List", "Product");
        }
    }
}
