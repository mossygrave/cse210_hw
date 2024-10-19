class Reflecting : Activity
{
    //Attributes 
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //Methods

    //Creates the reflection activity
    public Reflecting()
    {
        //sets the name and description
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    //Runs the reflecting activity
    public void Run()
    {
        //display welcome message and description
        DisplayStartingMessage();
        //selects a random prompt from a list
        DisplayPrompt();
        Console.Write("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine(); //there is probably a better way to do this 
        Console.WriteLine();
        //ask the user to reflect on the prompt 
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.Clear();

        //display a question from the list and ask the user to reflect on the question
        //pause and use a timer
        //move to the next question and pause again
        //repeat for duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime time;
        do
        {
            DisplayQuestion();
            ShowSpinner(9);

            time = DateTime.Now;
        } while (time < endTime); 

        //display ending message
        DisplayEndingMessage();
    }

    //display a random prompt
    public string GetRandomPrompt()
    {
        //returns a random prompt from a preset list
        Random random = new Random();
        int num = random.Next(0,3);

        string prompt = _prompts[num];
        return prompt;
    }

    //Gets a random question from a list
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int num = random.Next(0,8);

        string question = _questions[num];
        return question;
    }

    //displays the random prompt
    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }

    //displays the random question
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
    }
}