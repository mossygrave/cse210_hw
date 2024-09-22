using System;

// For refrence this is how comments work 
/*
And this is how multi line coments work
*/

class Program
{
    static void Main(string[] args)
    {
        //print example
        Console.WriteLine("Hello Sandbox World!");
        //WriteLine takes up the whole line while Write does not

        //input and var creation example
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
 
        //using a variable in a string example
        Console.WriteLine($"Your favorite color is {color}?");

        // if statement example
        if (color == "purple")
        {
            Console.WriteLine("Thats my favorite color too!");
            Console.WriteLine("");
        }
        else if (color == "yellow") //note c# uses else if rather than elif
        {
            Console.WriteLine("That's a good color");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Thats a cool color I guess");
            Console.WriteLine("");
        }

        //Operands and -> && or -> || not -> !

        //once defined a variable can't change type but you can create a new variable with the desired type
        Console.WriteLine("What is your favorite number? ");
        //always returns a string
        string faveNum = Console.ReadLine();
        //moves the number into an int variable
        int num = int.Parse(faveNum);
        //.ToString() converts to a string

        //Loops
        string response = "yes";

        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }

        //do-while loops run once and then check the condition
        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        
    }
}