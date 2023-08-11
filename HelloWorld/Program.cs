using System;

namespace HelloWorld
{
    public class Program
    {

        static void Main(string[] args)
        {
            //After using params
            Calculator.Add(1,2,3,4,5);
            Console.WriteLine(Calculator.total);
            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public static int total = 0;

        //Added params below
        public static int Add(params int[] numbers)
        {
            foreach (var n in numbers)
            {
                total += n;
            }

            return total;
        }
    }
}


