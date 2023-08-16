using System;
using System.Collections.Generic;

namespace HelloWorld {
    public class Canvas {
        public void DrawShapes(List<Shape> shapes) {
            foreach (var shape in shapes) {
                shape.Draw();
                }
            }
        }

    public partial class Program {
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




