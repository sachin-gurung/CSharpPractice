using System;

namespace HelloWorld {
    public class cat : Animal {
        string Color { get; set; }
        string Height { get; set; }

        public string makeSound() {
            return "Meow";
            }

        public void eat() {
            Console.WriteLine("Cats eat mice");
            }
        }
    }