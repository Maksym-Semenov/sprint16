# C-OnlineMarathon-Sprint16
C# Online Marathon Sprint 16. EFC
Your task is to create a Shopping system (registration of orders).
The system have to provide the storage of information about the date of the order, the store (supermarket), the list of ordered products and their quantity.
The customer would have the ability to select a store to purchase products, select the items from the list (with a view of the price) and specify the quantity of products.
The user has the opportunity to view the list of orders. After the specific order would be choosen, a complete information about the products (their quantity, price and total cost of the order) would be displayed.
Your task is to create a database according to the schema and define all the CRUD operations over the data.


![image](https://user-images.githubusercontent.com/35597862/201227917-c53367a7-e867-494f-9746-5fa45fcb6b1d.png)

1.	Create a data model:
    - Define classes: Product, Customer, Supermarket with properties according to schema. Don’t forget about properties appropriate to entities’ Primary keys;
    - Define class Order and OrderDetails with properties according to schema. Don’t forget about navigation properties (future entities’ Foreign keys).
2.	Create context class ShoppingContext and specify which entities are included in the data model: Products, Customers, Supermarkets, Orders, OrderDetails.
3.	Specify the connection service and options of AddDBContext in Startup.cs (ConfigureServices).
4.	Add connection string to appsettings.json.
5.	Create the class for seeding your DataBase (SampleData.cs). Define the ServiceProvider in Program.cs.
6.	Build the application. As the result you might have your DB in SQL Server Object Explorer. 
![image](https://user-images.githubusercontent.com/35597862/201228373-b3e2d345-4df5-47fd-9517-840269e08c86.png)
![image](https://user-images.githubusercontent.com/35597862/201228387-48b01d5e-5915-4089-aa66-576e7ff4822e.png)
![image](https://user-images.githubusercontent.com/35597862/201228405-00b245d6-dfbc-4096-bab2-ace53b8d8e0f.png)


Note. In case of any mistakes in DB schema you are able to alter the models, add migrations and update your database.
7.	Create controllers and views for Products, Supermarkets, Customers DataModels (use scaffolding). Change Index page of application (add navy-bars and links to appropriate Index pages of DataModels) 

![image](https://user-images.githubusercontent.com/35597862/201228438-408014c6-8409-4bbb-a47a-6895c30f3168.png)

8.	Add the ability to sort the list of customers by the last name or address (in descending and ascending order) 

![image](https://user-images.githubusercontent.com/35597862/201228458-cee4e427-0b7e-454b-b9f1-f1ca6d3b37fa.png)

9.	Add the ability to filter the list of customers by last or first name according to substring in input field 

![image](https://user-images.githubusercontent.com/35597862/201228490-675b739c-2f7b-4ad2-9057-2d72ce47c996.png)

10.	Add pagination to Supermarkets index page 

![image](https://user-images.githubusercontent.com/35597862/201228506-691ab308-5403-4e4a-8c1e-c7d031646f05.png)


11.	Create page Orders that reads and displays related data in the following ways 

![image](https://user-images.githubusercontent.com/35597862/201228521-d762bf38-b8c1-48b3-b2da-aa1151c4d634.png)

   - The list of orders displays related data from the Customers and Supermarkets entities;
   - When the user selects an order, related to it data from OrderDetails entity are displayed;

Note. While the creation of the items in entities that use the navigation properties user is able to see the real names of items (‘product name’ but not a ‘productId’, ‘supermarket name’ but not a ‘supermarketId’, etc).

Useful links:
https://docs.microsoft.com/ru-ru/aspnet/core/data/ef-mvc/?view=aspnetcore-3.1
