using System;

namespace HelloWorld {
    public class Rectangle : Shape {                 // Rectangle inherits from Shape. Has all the properties of Shape and can add more properties for Rectangle.
        public override void Draw() {
            Console.WriteLine("Draw a rectangle");
            }
        }
    }