using Microsoft.AspNetCore.Mvc;
using Sprint16.Models;
using System.Diagnostics;

namespace Sprint16.Controllers
{
    public class HomeController : Controller
    {
        private ShoppingContext db;
        public HomeController(ShoppingContext context)
        {
            this.db = context;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View(db.Customers);
        }
        public IActionResult Order()
        {
            return View(db.Orders);
        }
        public IActionResult OrderDetail()
        {
            return View(db.OrderDetails);
        }
        public IActionResult Product()
        {
            return View(db.Products);
        }
        public IActionResult SuperMarket()
        {
            return View(db.SuperMarkets);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}