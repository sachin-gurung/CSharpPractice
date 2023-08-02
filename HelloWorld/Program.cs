using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            //Rectangular Array
            var rectangularArray = new int[3, 5]
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}
            };

            Console.WriteLine(rectangularArray[2, 4]);

            //Jagged Array
            var jaggedArray = new int[3][];

            var array1 = new int[3] { 0, 1, 2 };
            var array2 = new int[4] { 3, 4, 5, 6 };
            var array3 = new int[2] { 7, 8 };

            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[1]);

            Console.WriteLine(array1.Length);
            Console.WriteLine(Array.IndexOf(array1, 2));

            //Clear - Sets the numbers to 0 when cleared, Boolean to false, Strings to null.
            Array.Clear(array2, 1, 2);
            foreach (var i in array2) {
                Console.WriteLine("array 4: " + i);
            }

            //Copy
            var array4 = new int[3];
            Array.Copy(array1, array4, 2);
            foreach (var i in array4) {
                Console.WriteLine(i);
            }
        }
    }
}
