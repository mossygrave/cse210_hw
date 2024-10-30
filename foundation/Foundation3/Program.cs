using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("Running", 30, 3.0);
        Swimming swimming = new Swimming("Swimming", 30, 10);
        Bicycles bicycles = new Bicycles("Bicycles", 30, 4.8);

        activities.Add(running);
        activities.Add(swimming);
        activities.Add(bicycles);

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}