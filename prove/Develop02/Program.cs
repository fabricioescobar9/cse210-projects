using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int numberChoice = 0;
        while (numberChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();
            numberChoice = int.Parse(userChoice);

            PromptGenerator responseQuestion = new PromptGenerator();
            responseQuestion._prompts.Add("Who was the most interesting person I interacted with today?");
            responseQuestion._prompts.Add("What was the best part of my day?");
            responseQuestion._prompts.Add("How did I see the hand of the Lord in my life today?");
            responseQuestion._prompts.Add("What was the strongest emotion I felt today?");
            responseQuestion._prompts.Add("If I had one thing I could do over today, what would it be?");

            // responseQuestion.GetRandomPrompt();

            if (numberChoice == 1)
            {

            }

            else if (numberChoice == 2)
            {
            Entry showEntries = new Entry();
            showEntries.Display();
            }

            else if (numberChoice == 3)
            {

            }

            else if (numberChoice == 4)
            {

            }
        }
    }
}