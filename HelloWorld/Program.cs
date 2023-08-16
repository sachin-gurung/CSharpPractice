using System;

namespace HelloWorld {
    public class Shape {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw() {
            Console.WriteLine("Draw a shape");
            }
        }

    public class Circle : Shape {
        public override void Draw() {
            Console.WriteLine("Draw a circle");
            }
        }

    public partial class Program {
        static void Main(string[] args) {
            var circle = new Circle();
            circle.Draw();
            Console.ReadLine();
            }
        }
    }



