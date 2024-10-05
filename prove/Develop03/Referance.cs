public class Referance
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Referance(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;      
    }

    public Referance(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;       
    }

    public void DisplayReferance()
    {
        if (_endVerse != 0)
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
    }
}