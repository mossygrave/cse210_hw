public class Entry
{
    // access an individual entry
    // hold the list of entries
    // has a variable for date, prompt text, and entry text
    public string _entryText;
    public string _date;
    public string _prompt;
    //public List<Entry> _entries = new List<Entry>();

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}  ");
        Console.WriteLine($"{_prompt}  ");
        Console.WriteLine($"> {_entryText}  ");
        Console.WriteLine("");
    }
    
}