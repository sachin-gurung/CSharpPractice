using System;

namespace HelloWorld {
    public class Program {

        public class Person {

            //Here, the "set" is private, so it can only be set in the constructor. 

            //This is a constructor. It can set the values of the private set properties.
            public Person(string name, int age) {
                Name = name;
                Age = age;
                }

            public string Name { get; private set; } //"set" is private
            public int Age { get; private set; }
            }

        static void Main(string[] args) {
            var person = new Person("John", 20);
            Console.WriteLine(person.Age);
            Console.ReadLine();

            }
        }
    }


