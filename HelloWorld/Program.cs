using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            var rectangularArray = new int[3, 5]
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}
            };

            Console.WriteLine(rectangularArray[2, 4]);

            var jaggedArray = new int[3][];

            var array1 = new int[3] { 0, 1, 2 };
            var array2 = new int[4] { 3, 4, 5, 6 };
            var array3 = new int[2] { 7, 8 };

            int v = array1[0];
            Console.WriteLine(v);
            Console.WriteLine(array2[1]);

            //Console.WriteLine(jaggedArray[array1[0]][array2[1]]);
            Console.WriteLine(jaggedArray[v] array2[1]);
        }
    }
}
