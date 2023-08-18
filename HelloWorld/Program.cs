using System;

namespace HelloWorld {
    /*
     * We rarely have to make Generic list. But this is the way to make it. Instead of making a list for each type, we can make a generic list. Instead of making bookList, IntList, ObjectList, we can make a generic list. This way, we can make a list for any type and we don't lose performance because we are not using object type.
     */

    public partial class Program {
        static void Main(string[] args) {

            // args => expression
            Func<int, int> square = number => number * number;    // number => number * number is a lambda expression. It is a function that takes a number and returns the square of that number.
            // Func<int, int> is a delegate. It is a pointer to a function. It is a type that can point to a function that takes an int and returns an int.
            Console.WriteLine(square(5));
            }
        }
    }




