class Listing : Activity
{
    //Attributes
    private int _count;
    private List<string> _prompts = new List<string>();

    //Methods

    //Create new listing activity
    public Listing()
    {
        //sets the name and description
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    //Runs the listing activity
    public void Run()
    {
        //starts with common starting message and description
        DisplayStartingMessage();
        Console.WriteLine();
        //displays a random prompt using GetRandomPrompt() 
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);


        //prompts the user to list items realted to the prompt and puts them in the _prompts list (uses GetListFromUser())
        List<string> userList = GetListFromUser();

        //displays how many items the user listed 
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");

        //shows the ending message
        DisplayEndingMessage();
    }

    //Generates a random prompt for the user
    public void GetRandomPrompt()
    {
        //displays a random prompt from a preset list
        Random random = new Random();
        int num = random.Next(0,4);

        Console.WriteLine("List as many resposes you can to the following prompt: ");
        Console.WriteLine($"--- {_prompts[num]} ---"); 
        
    }

    //Fills a list with data from the user
    public List<string> GetListFromUser()
    {
        //collects input from the user and puts it in the _prompts list 
        List<string> strings = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime time;

        do
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            strings.Add(input);

            time = DateTime.Now;
        } while (time < endTime);
        
        return strings;
    }
}