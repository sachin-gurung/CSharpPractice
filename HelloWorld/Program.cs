using System;

namespace HelloWorld {
    public class Program {

        static void Main(string[] args) {
            var cat1 = new cat();
            var animal1 = new Animal();

            Console.WriteLine(cat1.makeSound());
            Console.WriteLine(animal1.makeSound());
            Console.ReadLine();

            }
        }
    }


