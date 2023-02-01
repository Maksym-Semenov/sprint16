using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using sprint_16.Data;
using Sprint16.Models;
using System.Data;
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
            //if (User.Identity.IsAuthenticated)
            //{
            //    return Content(User.Identity.Name);
            //}
            //return Content("Not Authenticated");
            return View();
        }
        public ActionResult Customer(string sortOrder, string name)
        {
            ViewBag.LnameSortParm = String.IsNullOrEmpty(sortOrder) ? "Lname_desc" : "";
            ViewBag.AdressSortParm = sortOrder == "Adress_asc" ? "Adress_desc" : "Adress_asc";
            var customers = from s in db.Customers
                            select s;

            if (!string.IsNullOrEmpty(name))
            {
                customers = customers.Where(p => p.Fname!.Contains(name) || p.Lname!.Contains(name));
            }
           
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
       
        public IActionResult OrderDetail(int id)
        {
            IQueryable<OrderDetail> products;
            IQueryable<OrderDetail> detail;
            foreach (var product in db.Products)
            {
                products = db.OrderDetails.OrderByDescending(s => s.Id).Where(s => s.Id == product.Id);
            }

            detail = db.OrderDetails.Where(x => x.OrderId == id);
            if (detail != null)
            {
                return View(detail);
            }
            else
            {
                return RedirectToAction("Error404");
            }
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Order()
        {
            List<OrderInfo> orders = new List<OrderInfo>();

            string str_connection = @"Server=(localdb)\MSSQLLocalDB; Database=Sprint_16_DataBase; Trusted_Connection=True; MultipleActiveResultSets=true";

            SqlConnection con = new SqlConnection(str_connection);

            string query = "Select Orders.order_date,Customers.fname,Customers.lname,SuperMarkets.name from Orders inner join Customers ON Orders.customer_id = Customers.Id inner join SuperMarkets ON Orders.supermarket_id = SuperMarkets.Id";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            int i = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                string custm = "";
                OrderInfo info = new OrderInfo();
                info.Id = i;
                info.OrderDate = Convert.ToDateTime(dr["order_date"]);

                custm += dr["fname"].ToString();
                custm += " ";
                custm += dr["lname"].ToString();
                info.Customer = custm;

                info.SuperMarket = dr["name"].ToString();
                orders.Add(info);
                i++;
            }

            return View(orders);
        }
        
        public IActionResult Product()
        {
            return View(db.Products);
        }
        public IActionResult SuperMarket(int page)
        {
            if (page <= 0)
                page = 1;

            int limit = 2;
            int start = (int)(page - 1) * limit;
            int totalSuperm = db.SuperMarkets.Count();
            int numPage = totalSuperm / limit;

            ViewBag.TotalSuperm = totalSuperm;
            ViewBag.pageCurrent = page;
            ViewBag.Numpage = numPage;

            var DataSuperm = db.SuperMarkets.OrderByDescending(s => s.Id).Skip(start).Take(limit);
            return View(DataSuperm.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}