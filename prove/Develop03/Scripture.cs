public class Scripture
{
    string[] words;
    private Referance _referance = new Referance("John", 3, 16);
    private List<Word> _words = new List<Word>();
    

    //create the scripture with referance 
    public Scripture(string verse, Referance referance)
    {
        
        _referance = referance;
        //convert verse into a list of Word objects
        //create a loop to add each word to end of the list
        words = verse.Split(" ");
        foreach (string word in words)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }

    }

    public void DisplayScripture()
    {
        _referance.DisplayReferance();
        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
        Console.WriteLine("");
    }

    public void HideRandomWords(int numToHide)
    {
        int length = words.Length;
        
        for (int i = 0; i< numToHide; i++)
        {
            bool done = false;
            while (done != true)
            {
                int wordsLeft = 0;
                Random random = new Random();
                int index = random.Next(0, length);
                Word wordToHide = _words[index];
                bool hidden = wordToHide.IsHidden();
                if (hidden == false)
                {
                    wordToHide.Hide();
                    done = true;

                }

                if (done != true)
                {
                    foreach (Word word in _words)
                    {
                        bool check = word.IsHidden();
                        if (check == false)
                        {
                            wordsLeft += 1;
                        }
                    }
                    if (wordsLeft == 0)
                    {
                        done = true;

                    }
                }

            }
        }
    }

    public bool IsCompletelyHidden()
    {
        bool completelyHidden = true;
        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden();
            if (hidden == false)
            {
                completelyHidden = false;
            }
        }
        return completelyHidden;
    }
    //use verse to create a list of words
    //pick 3 random words to hide based on index from list
    //check if all words are hidden 
}