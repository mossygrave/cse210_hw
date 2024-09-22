using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magic number ");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        int guess;
        string input;
        int guessesNumber = 0;

        do
        {
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);
            Console.WriteLine("");

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            Console.WriteLine("");
            guessesNumber++;

        } while (guess != magic);

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {guessesNumber} tries.");
        Console.WriteLine("");
    }
}