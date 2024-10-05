public class Word
{

    private bool _isHidden = false;
    private string _word;

    
    public void Hide()
    {
        
        int length = _word.Length;
        _word = "";
        _isHidden = true;

        for (int i = 0; i < length; i++)
        {
            _word = _word + "_";
        }       

    }

    public Word(string word)
    {
        _word = word;
    }

    public void DisplayWord()
    {
        Console.Write($"{_word} ");
    }

    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}