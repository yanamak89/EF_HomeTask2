using Task1;

public class Program
{
    
    /*
     * Заповніть ваш список значеннями (10 значень).
       Виведіть на екран значення за індексом > 1, 5, 0, 7
       Знайдіть та виведіть індекси > 1, 5 за властивістю ProductId
       Знайдіть та виведіть індекси > 0, 7 за властивістю Name
     */
    public static void Main(string[] args)
    {
        // Вибір класу для роботи (Product, User або Order)
        string choice = "Order";

        List<Product> products = null;
        List<User> users = null;
        List<Order> orders = null;

        if (choice == "Product")
        { 
            products = new List<Product>
            {
                new Product {ProductId = Guid.NewGuid(), Name = "AirPods 1", Cost = 100, Description = "Description1", Quantity = 100},
                new Product {ProductId = Guid.NewGuid(), Name = "AirPods 2", Cost = 200, Description = "Description2", Quantity = 90},
                new Product {ProductId = Guid.NewGuid(), Name = "Apple watch 1", Cost = 300, Description = "Description3", Quantity = 80},
                new Product {ProductId = Guid.NewGuid(), Name = "Apple watch 2", Cost = 400, Description = "Description4", Quantity = 70},
                new Product {ProductId = Guid.NewGuid(), Name = "Iphone xs", Cost = 500, Description = "Description5", Quantity = 60},
                new Product {ProductId = Guid.NewGuid(), Name = "Iphone s max", Cost = 600, Description = "Description6", Quantity = 50},
                new Product {ProductId = Guid.NewGuid(), Name = "Iphone pro max", Cost = 700, Description = "Description7", Quantity = 40},
                new Product {ProductId = Guid.NewGuid(), Name = "iMac", Cost = 800, Description = "Description8", Quantity = 30},
                new Product {ProductId = Guid.NewGuid(), Name = "MacBook Air", Cost = 100, Description = "Description9", Quantity = 20},
                new Product {ProductId = Guid.NewGuid(), Name = "MacBook pro", Cost = 100, Description = "Description10", Quantity = 10}
            };
            
            // Виведення значень за індексами 1, 5, 0, 7
            Console.WriteLine("Product indexes by ProductId: ");
            Console.WriteLine(products[1].Name);
            Console.WriteLine(products[5].Name);
            Console.WriteLine(products[0].Name);
            Console.WriteLine(products[7].Name);
            
            // Пошук та виведення індексів за властивістю ProductId
            Console.WriteLine("\nProduct indexes by ProductId: ");
            Console.WriteLine("Index of Product with ProductId " + products[1].ProductId + ": " + products.FindIndex(p => p.ProductId == products[1].ProductId));
            Console.WriteLine("Index of Product with ProductId " + products[5].ProductId + ": " + products.FindIndex(p => p.ProductId == products[5].ProductId));
            
            //Знайдіть та виведіть індекси > 0, 7 за властивістю Name
            // Пошук та виведення індексів за властивістю Name
            Console.WriteLine("\nProduct indexes by Name: ");
            Console.WriteLine("Index of Product with Name " + products[0].Name  + ": " + products.FindIndex(p => p.Name == products[0].Name));
            Console.WriteLine("Index of Product with Name " + products[7].Name + ": " + products.FindIndex(p => p.Name == products[7].Name));
        }
        else if (choice == "User")
        {
            users = new List<User>
            {
                new User { UserId = Guid.NewGuid(), Name = "John", LastName = "Doe", Login = "john.doe", Password = "password1", Email = "john.doe@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Jane", LastName = "Doe", Login = "jane.doe", Password = "password2", Email = "jane.doe@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Bob", LastName = "Smith", Login = "bob.smith", Password = "password3", Email = "bob.smith@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Alice", LastName = "Johnson", Login = "alice.johnson", Password = "password4", Email = "alice.johnson@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Charlie", LastName = "Brown", Login = "charlie.brown", Password = "password5", Email = "charlie.brown@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Eve", LastName = "White", Login = "eve.white", Password = "password6", Email = "eve.white@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Frank", LastName = "Black", Login = "frank.black", Password = "password7", Email = "frank.black@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Grace", LastName = "Green", Login = "grace.green", Password = "password8", Email = "grace.green@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Hank", LastName = "Blue", Login = "hank.blue", Password = "password9", Email = "hank.blue@example.com" },
                new User { UserId = Guid.NewGuid(), Name = "Ivy", LastName = "Red", Login = "ivy.red", Password = "password10", Email = "ivy.red@example.com" }
            };
            // Виведення значень за індексами 1, 5, 0, 7
            Console.WriteLine("Product indexes by ProductId: ");
            Console.WriteLine(users[1].Name);
            Console.WriteLine(users[5].Name);
            Console.WriteLine(users[0].Name);
            Console.WriteLine(users[7].Name);
            
            // Пошук та виведення індексів за властивістю ProductId
            Console.WriteLine("\nUser indexes by ProductId: ");
            Console.WriteLine("Index of User with ProductId " + users[1].UserId + ": " + users.FindIndex(u => u.UserId == users[1].UserId));
            Console.WriteLine("Index of User with ProductId " + users[5].UserId + ": " + users.FindIndex(u => u.UserId == users[5].UserId));
            
            //Знайдіть та виведіть індекси > 0, 7 за властивістю Name
            // Пошук та виведення індексів за властивістю Name
            Console.WriteLine("\nUser indexes by Name: ");
            Console.WriteLine("Index of User by Name " + users[0].Name + ": " + users.FindIndex(u => u.Name == users[0].Name));
            Console.WriteLine("Index of User by Name " + users[0].Name + ": " + users.FindIndex(u => u.Name == users[7].Name));
        }
        else if (choice == "Order")

        {
            orders = new List<Order>
            {
                new Order { OrderId = Guid.NewGuid(), Name = "Order1", Create = DateTime.Now.AddDays(-10), Update = DateTime.Now, Description = "Order for electronics" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order2", Create = DateTime.Now.AddDays(-9), Update = DateTime.Now, Description = "Order for furniture" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order3", Create = DateTime.Now.AddDays(-8), Update = DateTime.Now, Description = "Order for groceries" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order4", Create = DateTime.Now.AddDays(-7), Update = DateTime.Now, Description = "Order for books" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order5", Create = DateTime.Now.AddDays(-6), Update = DateTime.Now, Description = "Order for toys" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order6", Create = DateTime.Now.AddDays(-5), Update = DateTime.Now, Description = "Order for clothing" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order7", Create = DateTime.Now.AddDays(-4), Update = DateTime.Now, Description = "Order for kitchenware" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order8", Create = DateTime.Now.AddDays(-3), Update = DateTime.Now, Description = "Order for office supplies" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order9", Create = DateTime.Now.AddDays(-2), Update = DateTime.Now, Description = "Order for outdoor gear" },
                new Order { OrderId = Guid.NewGuid(), Name = "Order10", Create = DateTime.Now.AddDays(-1), Update = DateTime.Now, Description = "Order for automotive parts" }
            };
        }

        // Виведення значень за індексами 1, 5, 0, 7
            Console.WriteLine("Orders indexes by ProductId: ");
            Console.WriteLine(orders[1].Name);
            Console.WriteLine(orders[5].Name);
            Console.WriteLine(orders[0].Name);
            Console.WriteLine(orders[7].Name);
            
            Console.WriteLine("Orders Description by ProductId: ");
            Console.WriteLine(orders[1].Description);
            Console.WriteLine(orders[5].Description);
            Console.WriteLine(orders[0].Description);
            Console.WriteLine(orders[7].Description);
            
            // Пошук та виведення індексів за властивістю ProductId
            Console.WriteLine("\nOrders indexes by ProductId: ");
            Console.WriteLine("Index of Orders with ProductId " + orders[1].OrderId + ": " + orders.FindIndex(o => o.OrderId == orders[1].OrderId));
            Console.WriteLine("Index of Orders with ProductId " + orders[5].OrderId + ": " + orders.FindIndex(o => o.OrderId == orders[5].OrderId));
            
            //Знайдіть та виведіть індекси > 0, 7 за властивістю Name
            // Пошук та виведення індексів за властивістю Name
            Console.WriteLine("\nOrders indexes by Name: ");
            Console.WriteLine("Index of Orders by Name " + orders[0].Name + ": " + orders.FindIndex(o => o.Name == orders[0].Name));
            Console.WriteLine("Index of Orders by Name " + orders[0].Name + ": " + orders.FindIndex(o => o.Name == orders[7].Name));
        }
    }
