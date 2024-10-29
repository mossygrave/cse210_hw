public class Animations
{
    public void ShowSpinner(int seconds)
    {
        //uses the number of seconds to play the spinner for that amount of time
        //... animation
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
        Console.Clear();
    }

    //its dangerous to go alone. Take this
// __-----_________________{]__________________________________________________
//{&&&&&&&#%%&#%&%&%&%&%#%&|]__________________________________________________\
//                         {]     ¯\_(◕ᗜ◕)_/¯
//                                   _/   \_

}