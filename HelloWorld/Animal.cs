using System;

namespace HelloWorld {
    public class Animal {
        private int Age { get; set; }
        private int Name { get; set; }

        public string makeSound() {
            return "Animals can make sound";
            }

        public void eat() {
            Console.WriteLine("Animals can eat");
            }

        }
    }