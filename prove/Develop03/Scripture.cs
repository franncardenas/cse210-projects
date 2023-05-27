class Scripture
{
    private string _reference;
    private List<Word> _wordsList = new List<Word>();
    
    //Constructor
    public Scripture(string reference, string texScripture)
    {
        string[] wordsScripture = texScripture.Split(' ');

        foreach (var wordScripture in wordsScripture)
        {
            Word oneWord = new Word(wordScripture);
            _wordsList.Add(oneWord);
        }
        _reference = reference;
    }

    //Behaviors 
    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(2, 4);
        int wordsHidden = 0;

        while (wordsHidden < wordsToHide)
        {
            int randomIndex = random.Next(0, _wordsList.Count);

            if (!_wordsList[randomIndex].IsHidden())
            {
                _wordsList[randomIndex].Hide();
                wordsHidden++;
            }
        }

        Console.Clear();
        GetRenderedText();
    
    }

    public void GetRenderedText()
    {
        Console.Write($"{_reference} " );
        foreach (Word word in _wordsList)
        {
            Console.Write(word.GetWord() + " ");
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _wordsList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}