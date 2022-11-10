# C-OnlineMarathon-Sprint16
C# Online Marathon Sprint 16. EFC
Your task is to create a Shopping system (registration of orders).
The system have to provide the storage of information about the date of the order, the store (supermarket), the list of ordered products and their quantity.
The customer would have the ability to select a store to purchase products, select the items from the list (with a view of the price) and specify the quantity of products.
The user has the opportunity to view the list of orders. After the specific order would be choosen, a complete information about the products (their quantity, price and total cost of the order) would be displayed.
Your task is to create a database according to the schema and define all the CRUD operations over the data.

![DBschema](/images/1.png)

1.	Create a data model:
    - Define classes: Product, Customer, Supermarket with properties according to schema. Don’t forget about properties appropriate to entities’ Primary keys;
    - Define class Order and OrderDetails with properties according to schema. Don’t forget about navigation properties (future entities’ Foreign keys).
2.	Create context class ShoppingContext and specify which entities are included in the data model: Products, Customers, Supermarkets, Orders, OrderDetails.
3.	Specify the connection service and options of AddDBContext in Startup.cs (ConfigureServices).
4.	Add connection string to appsettings.json.
5.	Create the class for seeding your DataBase (SampleData.cs). Define the ServiceProvider in Program.cs.
6.	Build the application. As the result you might have your DB in SQL Server Object Explorer. 

![DB1](/images/2.PNG)
![DB2](/images/3.PNG)
![DB3](/images/4.PNG)

Note. In case of any mistakes in DB schema you are able to alter the models, add migrations and update your database.
7.	Create controllers and views for Products, Supermarkets, Customers DataModels (use scaffolding). Change Index page of application (add navy-bars and links to appropriate Index pages of DataModels) 

![Index](/images/5.PNG)

8.	Add the ability to sort the list of customers by the last name or address (in descending and ascending order) 

![Order](/images/6.PNG)

9.	Add the ability to filter the list of customers by last or first name according to substring in input field 

![Filter](/images/7.PNG)

10.	Add pagination to Supermarkets index page 

![Pagination](/images/8.png)


11.	Create page Orders that reads and displays related data in the following ways 

![Orders](/images/9.png)

   - The list of orders displays related data from the Customers and Supermarkets entities;
   - When the user selects an order, related to it data from OrderDetails entity are displayed;

Note. While the creation of the items in entities that use the navigation properties user is able to see the real names of items (‘product name’ but not a ‘productId’, ‘supermarket name’ but not a ‘supermarketId’, etc).

Useful links:
https://docs.microsoft.com/ru-ru/aspnet/core/data/ef-mvc/?view=aspnetcore-3.1
