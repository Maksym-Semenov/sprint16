using Microsoft.AspNetCore.Mvc;
using sprint_16.Data;
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
            SampleData.CreateData(db);
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Customer(string sortOrder)
        {
            ViewBag.LnameSortParm = String.IsNullOrEmpty(sortOrder) ? "Lname_desc" : "";
            ViewBag.AdressSortParm = sortOrder == "Adress_asc" ? "Adress_desc" : "Adress_asc";
            var customers = from s in db.Customers
                            select s;
            switch (sortOrder)
            {
                case "Lname_desc":
                    customers = customers.OrderByDescending(s => s.Lname);
                    break;
                case "Adress_asc":
                    customers = customers.OrderBy(s => s.Adress);
                    break;
                case "Adress_desc":
                    customers = customers.OrderByDescending(s => s.Adress);
                    break;
                default:
                    customers = customers.OrderBy(s => s.Lname);
                    break;
            }
            return View(customers.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //public IActionResult Customer()
        //{
        //    return View(db.Customers);
        //}
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