using System;

namespace HelloWorld {
    public class Circle : Shape {                     // Circle inherits from Shape. Has all the properties of Shape and can add more properties for Circle.
        public override void Draw() {
            Console.WriteLine("Draw a circle");
            }
        }
    }