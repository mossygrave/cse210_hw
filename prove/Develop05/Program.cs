using System;

class Program
{
    static void Main(string[] args)
    {
        //Mindfulness Program
        //Menu to navigate the program 
        bool quit = false;

        //Creating all the activities
        Breathing breathing = new Breathing();
        Reflecting reflecting = new Reflecting();
        Listing listing = new Listing();
        


        while (quit != true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (input == "4")
            {
                quit = true;
            }
            else if (input == "1")
            {
                //run the breathing activity
                Console.Clear();
                breathing.Run();
            }
            else if (input == "2")
            {
                //run the reflecting activity
                Console.Clear();
                reflecting.Run();
            }
            else if (input == "3")
            {
                //run the listing activity
                Console.Clear();
                listing.Run();
            }
        }
    }
}