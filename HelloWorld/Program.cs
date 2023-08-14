using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            var customer1 = new Customer(1, "John");
            var customer2 = new Customer(2, "Mary");
            var customer3 = new Customer(3, "Mark");

            customer1.Orders.Add(new Order { id = 1, name = "Order 1" });
            customer1.Orders.Add(new Order { id = 2, name = "Order 2" });

            Console.WriteLine(customer1.Orders.Count);

            customer1.createOrder();

            Console.WriteLine(customer1.Orders.Count);
            Console.ReadLine();
            }
        }
    }


