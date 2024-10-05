using System;

class Program
{
    static void Main(string[] args)
    {
        //print scripture
        //prompt user to continue or quit
        //if the user continues (presses enter) console should clear
        //if user types quit the program should end

        bool quit = false;
        int numToHide;


        Console.Write("Please input the text you would like to memorize: ");
        string text = Console.ReadLine();
        Console.Write("Please input the book: ");
        string book = Console.ReadLine();
        Console.Write("Please input the chapter: ");
        string input = Console.ReadLine();
        int chapter = int.Parse(input);
        Console.Write("Please input the starting verse: ");
        input = Console.ReadLine();
        int verse = int.Parse(input);
        Console.Write("Please input the end verse (if none type 0): ");
        input = Console.ReadLine();
        int endVerse = int.Parse(input);

        Referance referance = new Referance(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(text, referance);
        Random random = new Random();

        while (quit == false)
        {
            Console.Clear();
            scripture.DisplayScripture();
            //Console.WriteLine("");
            Console.Write("Press enter to continue or type quit to exit the program: ");
            input = Console.ReadLine();
            input = input.ToLower();

            if (input == "quit")
            {
                quit = true;
            }
            else
            {
                numToHide = random.Next(1, 5);
                scripture.HideRandomWords(numToHide);
                bool hidden = scripture.IsCompletelyHidden();
                if (hidden == true)
                {
                    quit = true;
                }
            }


        }
        Console.Clear();
        scripture.DisplayScripture();
        Console.WriteLine("");
        Console.WriteLine("You have completed the scripture memorizer!");


            
    }
}