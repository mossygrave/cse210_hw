class Activity
{
    //base class for all the activities

    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //Methods

    //Creates an Activity
    public Activity()
    {
        //I dont know what's in here
    }

    //Shows the starting message
    public void DisplayStartingMessage()
    {
        //print the welcome message that is the same for each activity
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds would you like your session to last? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input); //this should work
        Console.Clear();
        Console.Write("Get ready");
        ShowSpinner(3);

    }

    //Shows the ending message
    public void DisplayEndingMessage()
    {
        //print the common ending message
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.Write($"You have completed another {_duration} seconds of the {_name} activity");
        ShowSpinner(3);
    }

    //Plays the loading animation (spinner)
    public void ShowSpinner(int seconds)
    {
        //uses the number of seconds to play the spinner for that amount of time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime )
        {
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("\b\b\b   \b\b\b");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    //Plays a countdown 
    public void ShowCountDown(int seconds)
    {
        //counts down the number of seconds
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}