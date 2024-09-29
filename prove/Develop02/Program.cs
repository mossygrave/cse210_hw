using System;

class Program
{
    static void Main(string[] args)
    {
        // menu 

        //display all the entries 
        bool exit = false;


        Prompts prompt = new Prompts();
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");

        Journal journal = new Journal();
        
        while (exit == false)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu");
            Console.WriteLine("");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. All Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (Input a number) ");
            string input = Console.ReadLine();
            int action = int.Parse(input);
            //using int instead of string so I dont have to worry about capitals

            Console.WriteLine("");

            // if statements with each of the menu options
            if (action == 5) //Quit
            {
                Console.Write("Would you like to save first? (Y/N) ");
                string saving = Console.ReadLine();

                if (saving == "Y" || saving == "y")
                {
                    journal.SaveJournal();
                    Console.WriteLine("Save complete");
                    Console.WriteLine("Exiting Journal");
                    exit = true;
                }
                else if (saving == "N" || saving == "n")
                {
                    Console.WriteLine("Exiting Journal");
                    exit = true;
                }                
            }
            else if (action == 1) //New Entry
            {
                Entry entry = new Entry();

                //get and display prompt
                entry._prompt = prompt.PromptGenerator();
                Console.WriteLine(entry._prompt);
            
                //get text from user
                Console.Write(">");
                entry._entryText = Console.ReadLine();
                Console.WriteLine("");

                //get date using DateTime
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();

                //save entry to entries list
                journal._journal.Add(entry);

                //entry.DisplayEntry();

            }
            else if (action == 2) //All Entries
            {
                //access journal file and iterate through all entries
                journal.DisplayJournal();
            }
            else if (action == 3) //Save Journal
            {
                //get file name from user 
                //save file from the Journal class
                journal.SaveJournal();
            }
            else if (action == 4) //Load Journal
            {
                //get filename from user
                //iterate through the list of entries
                //replace any entries stored in the journal file 
                journal._journal = journal.LoadJournal();
            }
            else 
            {
                Console.WriteLine("Please input a valid option");
                Console.WriteLine("");
            }
        }
    }
}