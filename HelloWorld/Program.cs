using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            int randomNumber = new Random().Next(1, 10);
            int userGuessedNumber;
            int numberOfChances = 4;
            Console.WriteLine(randomNumber);

            for (int i = 0; i < numberOfChances; i++) {
                Console.Write("Guess the correct number: ");
                userGuessedNumber = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == userGuessedNumber) {
                    Console.WriteLine("You win");
                    break;
                } else {
                    Console.WriteLine("Incorrect");
                }
            }

            Console.WriteLine("Game over....");
        }
    }
}
