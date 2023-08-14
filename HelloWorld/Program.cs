using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            var customer1 = new Customer();
            customer1.setId(1);
            customer1.setName("John");

            Console.WriteLine(customer1.getName());
            Console.ReadLine();
            }
        }
    }


