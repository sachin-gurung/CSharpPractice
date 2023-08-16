using System;
using System.Collections.Generic;

namespace HelloWorld {
    public class Canvas {                             // Canvas is a class that has a method that takes a list of shapes and draws them.
        public void DrawShapes(List<Shape> shapes) {
            foreach (var shape in shapes) {
                shape.Draw();
                }
            }
        }

    public partial class Program {                    // Program is a class that has a Main method that creates a list of shapes and passes it to the DrawShapes method of the Canvas class.
        static void Main(string[] args) {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
            Console.ReadLine();
            }
        }
    }




