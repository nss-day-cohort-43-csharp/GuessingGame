using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a friggen number: ");
            string userResponse = Console.ReadLine();
            int guess = int.Parse(userResponse);

            int secretNumber = 42;

            if (guess == secretNumber)
            {
                Console.WriteLine("Ya! You guessed it!");
            }
            else
            {
                Console.WriteLine("Nope that wasn't it...");
            }
        }
    }
}