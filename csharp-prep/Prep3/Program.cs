using System;
using System.Diagnostics;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {  
        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guess = 0;
            int guessCount = 0;

            while (number != guess)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);  

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    guessCount++; 
                }

                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    guessCount++; 
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    guessCount++; 
                }
            }

            Console.WriteLine($"It took {guessCount} guesses");

            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
            Console.WriteLine();
        }
    }   
}