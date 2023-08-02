using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
<<<<<<< HEAD

            int sum = 0;

            while (true) {

                Console.Write("Enter a number or \"ok\" to exit:");
                var input = Console.ReadLine();

                if (input == "ok") {
                    break;
                }

                var number = Convert.ToInt32(input);
                sum += number;
            }
            Console.WriteLine(sum);
=======
            int number;
            int result = 1;
            Console.Write("Enter a number: ");
            number = Convert.ToByte(Console.ReadLine());

            for (int i = number; i > 0; i--) {
                result *= i;
            }
            Console.WriteLine(result);
>>>>>>> SachinSandBox
        }
    }
}
