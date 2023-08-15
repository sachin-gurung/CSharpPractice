using System;

namespace HelloWorld {
    public partial class Program {
        public class Car : Vehicle {
            public Car(string registrationNumber)
            : base(registrationNumber) {
                Console.WriteLine("This is a Car constructor.");
                }
            }
        }
    }