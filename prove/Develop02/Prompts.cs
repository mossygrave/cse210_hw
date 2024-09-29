

public class Prompts
{
    // create list with prompts
    // Generate random number from 0-4
    // use that as the index of the list
    // display prompt 
    string prompt;
    public List<string> _prompts = new List<string>();

    public string PromptGenerator()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, 4);

        prompt = _prompts[num];        

        return prompt;
    }

/*

    if (num == 0)
        {
            prompt = "Who was the most interesting person I interacted with today?";
        }
        else if (num == 1)
        {
            prompt = "What was the best part of my day?";
        }
        else if (num == 2)
        {
            prompt = "How did I see the hand of the Lord in my life today?";
        }
        else if (num == 3)
        {
            prompt = "What was the strongest emotion I felt today?";
        }
        else if (num == 4)
        {
            prompt = "If I had one thing I could do over today, what would it be?";
        }
*/
}