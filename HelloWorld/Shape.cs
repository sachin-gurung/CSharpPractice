namespace HelloWorld {
    public abstract class Shape {                              // Shape is the abstract base class. Now all derived classes need to write their own Draw() method. Otherwise the program won't compile. 
        int X { get; set; }
        int Y { get; set; }
        string Color { get; set; }
        string Name { get; set; }
        public abstract void Draw();
        }
    }