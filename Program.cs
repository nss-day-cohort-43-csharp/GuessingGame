using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNumber = 42;
            int numberOfAttempts = 0;

            while (numberOfAttempts < 4)
            {
                Console.Write("Guess a friggen number: ");
                string userResponse = Console.ReadLine();
                int guess = int.Parse(userResponse);

                if (guess == secretNumber)
                {
                    Console.WriteLine("Ya! You guessed it!");
                    break;
                }
                else
                {
                    Console.WriteLine("Nope that wasn't it...");
                    numberOfAttempts++;
                }
            }
        }
    }
}