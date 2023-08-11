using System;

namespace HelloWorld
{
    public class Program
    {

        static void Main(string[] args)
        {
            Calculator.Add(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(Calculator.total);
            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public static int total = 0;
        public static int Add(int[] numbers)
        {
            foreach (var n in numbers)
            {
                total += n;
            }

            return total;
        }
    }
}


