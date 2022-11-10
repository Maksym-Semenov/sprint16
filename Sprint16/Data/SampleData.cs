using Sprint16.Models;

namespace sprint_16.Data
{
    public class SampleData
    {
        public static void CreateData(ShoppingContext db)
        {
            if (db.Customers.Count() == 0)
            {
                Customer customer1 = new Customer { Fname = "Artem", Lname = "Tazq", Adress = "adress1", Dicsount = 10 };
                Customer customer2 = new Customer { Fname = "Kris", Lname = "Ban", Adress = "adress2", Dicsount = 15 };
                Customer customer3 = new Customer { Fname = "Anna", Lname = "Kilz", Adress = "adress3", Dicsount = 5 };
                Customer customer4 = new Customer { Fname = "Julia", Lname = "Rik", Adress = "adress4", Dicsount = 15 };
                Customer customer5 = new Customer { Fname = "Ivan", Lname = "Pop", Adress = "adress5", Dicsount = 5 };
                Customer customer6 = new Customer { Fname = "Jack", Lname = "Vall", Adress = "adress6", Dicsount = 20 };
                Customer customer7 = new Customer { Fname = "Dan", Lname = "Snik", Adress = "adress7", Dicsount = 10 };
                Customer customer8 = new Customer { Fname = "Pip", Lname = "Don", Adress = "adress8", Dicsount = 5 };
                db.Customers.AddRange(customer1, customer2, customer3, customer4, customer5, customer6, customer7, customer8);

                SuperMarket superMarket1 = new SuperMarket { Name = "Varus", Adress = "Odessa" };
                SuperMarket superMarket2 = new SuperMarket { Name = "Comfy", Adress = "Kyiv" };
                SuperMarket superMarket3 = new SuperMarket { Name = "ATB", Adress = "Dnipro" };
                SuperMarket superMarket4 = new SuperMarket { Name = "Silpo", Adress = "Lviv" };
                db.SuperMarkets.AddRange(superMarket1, superMarket2, superMarket3, superMarket4);


                Order order1 = new Order { OrderDate = new DateTime(2022, 09, 12), Customer = customer2, Supermarket = superMarket1, CustomerId = customer2.Id, SupermarketId = superMarket1.Id };
                Order order2 = new Order { OrderDate = new DateTime(2022, 06, 29), Customer = customer3, Supermarket = superMarket4, CustomerId = customer3.Id, SupermarketId = superMarket4.Id };
                Order order3 = new Order { OrderDate = new DateTime(2021, 12, 08), Customer = customer4, Supermarket = superMarket1, CustomerId = customer4.Id, SupermarketId = superMarket1.Id };
                Order order4 = new Order { OrderDate = new DateTime(2020, 01, 22), Customer = customer7, Supermarket = superMarket2, CustomerId = customer7.Id, SupermarketId = superMarket2.Id };
                Order order5 = new Order { OrderDate = new DateTime(2021, 03, 12), Customer = customer1, Supermarket = superMarket3, CustomerId = customer1.Id, SupermarketId = superMarket3.Id };
                Order order6 = new Order { OrderDate = new DateTime(2019, 12, 05), Customer = customer5, Supermarket = superMarket3, CustomerId = customer5.Id, SupermarketId = superMarket3.Id };
                Order order7 = new Order { OrderDate = new DateTime(2022, 05, 23), Customer = customer8, Supermarket = superMarket2, CustomerId = customer8.Id, SupermarketId = superMarket2.Id };
                Order order8 = new Order { OrderDate = new DateTime(2019, 03, 16), Customer = customer6, Supermarket = superMarket4, CustomerId = customer6.Id, SupermarketId = superMarket4.Id };

                db.Orders.AddRange(order1, order2, order3, order4, order5, order6, order7, order8);

                Product product1 = new Product { Name = "Milk", Price = 15 };
                Product product2 = new Product { Name = "Kefir", Price = 25 };
                Product product3 = new Product { Name = "Meat", Price = 35 };
                Product product4 = new Product { Name = "Banana", Price = 45 };
                Product product5 = new Product { Name = "Sausage", Price = 75 };
                Product product6 = new Product { Name = "Apple", Price = 65 };
                Product product7 = new Product { Name = "Sugar", Price = 95 };
                Product product8 = new Product { Name = "Solt", Price = 85 };
                db.Products.AddRange(product1, product2, product3, product4, product5, product6, product7, product8);

                OrderDetail detail1 = new OrderDetail { Quantity = 5.25, Product = product1, Order = order1, OrderId = order1.Id, ProductId = product1.Id };
                OrderDetail detail2 = new OrderDetail { Quantity = 4.15, Product = product3, Order = order5, OrderId = order5.Id, ProductId = product3.Id };
                OrderDetail detail3 = new OrderDetail { Quantity = 9, Product = product6, Order = order2, OrderId = order2.Id, ProductId = product6.Id };
                OrderDetail detail4 = new OrderDetail { Quantity = 10, Product = product8, Order = order4, OrderId = order4.Id, ProductId = product8.Id };
                OrderDetail detail5 = new OrderDetail { Quantity = 8, Product = product2, Order = order6, OrderId = order6.Id, ProductId = product2.Id };
                OrderDetail detail6 = new OrderDetail { Quantity = 8.5, Product = product7, Order = order7, OrderId = order7.Id, ProductId = product7.Id };
                OrderDetail detail7 = new OrderDetail { Quantity = 30.75, Product = product4, Order = order3, OrderId = order3.Id, ProductId = product4.Id };
                OrderDetail detail8 = new OrderDetail { Quantity = 30.75, Product = product5, Order = order8, OrderId = order8.Id, ProductId = product5.Id };
                db.OrderDetails.AddRange(detail1, detail2, detail3, detail4, detail5, detail6, detail7, detail8);

                db.SaveChanges();
            }
        }
    }
}
