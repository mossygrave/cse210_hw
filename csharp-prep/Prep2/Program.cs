using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage did you get? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        Console.WriteLine("");

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("");
            Console.WriteLine("Congratulations! You have passed!");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("You didn't pass... better luck next time.");
        }
        Console.WriteLine("");
    }
}