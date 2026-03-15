using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int numberChoice = 0;
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
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

            if (numberChoice == 1)
            {
               theJournal.AddEntry(anEntry);
            }

            else if (numberChoice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (numberChoice == 3)
            {   
                Console.WriteLine("What is the filename? ");
                string loadFileName = Console.ReadLine();
                theJournal.LoadFromFile(loadFileName);
            }

            else if (numberChoice == 4)
            {
                Console.WriteLine("What is the filename? ");
                string saveFileName = Console.ReadLine();
                theJournal.SaveToFile(saveFileName);
            }
        }
    }
}