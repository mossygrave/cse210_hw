class Breathing : Activity
{
    //Guides the user through a breathing exercise

    //creates a breathing activity
    public Breathing()
    {
        //Transfers the duration, name and description for the activity
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    //Runs the breathing exercise
    public void Run()
    {
        //using the duration from the activity class creates a breathing activity
        //displays welcome message and description at beginning and ending message at the end
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime time;

        do
        {
            Console.WriteLine();
            Console.Write(" Breathe in..."); 
            ShowCountDown(5);

            Console.Write(" Breathe out...");
            ShowCountDown(5);
            //maybe add another space here 
            
            time = DateTime.Now;

        } while (time < endTime); 

        DisplayEndingMessage();
    }
}