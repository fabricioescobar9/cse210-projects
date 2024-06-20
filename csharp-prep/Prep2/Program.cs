using System;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("What is your grade? ");
        string userGrade = Console.ReadLine();
        int numberGrade = int.Parse(userGrade);
        Console.WriteLine("");
        string letter = null;
        string gradeSign = null;

        if (numberGrade >= 90)
        {
            letter = "A";
        }

        else if (numberGrade >= 80)
        {
            letter = "B";
        }

        else if (numberGrade >= 70)
        {
            letter = "C";
        }

        else if (numberGrade >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        if (numberGrade >= 93 || numberGrade < 60)
        {
            gradeSign = null;
        } 
        else
        {
            if (numberGrade % 10 >= 7)
            {
                gradeSign = "+";
            }

            else if (numberGrade % 10 <3)
            {
                gradeSign = "-";
            }

            else
            {
                gradeSign = null;
            }      
        } 
        
        Console.WriteLine($"Your grade is {letter}{gradeSign}");

        if (numberGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed successfully the class.");
        }

        else
        {
            Console.WriteLine("You didn't pass the class. Try a little harder next time and cheer up.");
        }    
    }
}