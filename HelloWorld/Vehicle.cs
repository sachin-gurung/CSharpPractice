using System;

namespace HelloWorld {
    public partial class Program {
        public class Vehicle {
            //public Vehicle() {
            //    Console.WriteLine("This is a Vehicle constructor.");
            //    }

            public Vehicle(string registrationNumber) {
                Console.WriteLine("This is a Vehicle constructor with registration number {0}", registrationNumber);
                }
            }
        }
    }