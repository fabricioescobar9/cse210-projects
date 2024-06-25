using System;
using System.Globalization;
using System.Collections.Generic; 


class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();

        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(userNumber != 0)
        {
            Console.Write("Enter number: ");

            string numberInput = Console.ReadLine();
            userNumber = int.Parse(numberInput);

            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sumNumbers = 0;

        foreach (int number in numbers)
        {
            sumNumbers += number; 
        }

        Console.WriteLine($"The sum is: {sumNumbers}");

        float averageNumbers = ((float)sumNumbers) / numbers.Count;

        Console.WriteLine($"The average is: {averageNumbers}");

        int maxNumbers = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumbers)
            {
                maxNumbers = number;
            }
        }

        Console.WriteLine($"The max is: {maxNumbers}");

        int minNumbers = numbers[0];

        foreach (int number in numbers)
        {
            if (number < minNumbers && number > 0)
            {
                minNumbers = number;
            }
        }

        Console.WriteLine($"The min positive is: {minNumbers}");

        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}