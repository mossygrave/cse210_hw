//Saves all entries and has access to all
using System.IO;
using System;
using Microsoft.VisualBasic;

public class Journal
{
    //include list of all the entries
    public List<Entry> _journal = new List<Entry>();

    //display all entries
    Entry entries = new Entry();

    public void DisplayJournal()
    {
        foreach (Entry entry in _journal)
        {
            entry.DisplayEntry();
        }
    } 

    //save Journal to a text file
    public void SaveJournal()
    {
        Console.Write("What would you like to name your file? (Include .txt) ");
        string fileName = Console.ReadLine();

        foreach (Entry item in _journal)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine($"{item._date}~|~{item._prompt}~|~{item._entryText}");
            }
        }

    }

    //read text file and put info into a list
    public List<Entry> LoadJournal()
    {
        List<Entry> entries = new List<Entry>();

        Console.Write("Which file would you like to load? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            
            Entry entry1 = new Entry();
            entry1._date = parts[0];
            entry1._prompt = parts[1];
            entry1._entryText = parts[2];

            entries.Add(entry1);
        }

        return entries;        

    }

}