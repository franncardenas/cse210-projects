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
    public int HideWords(int totalHidden)
    {
        Random random = new Random();
        int wordsHidden = 0; 
        int diff = _wordsList.Count - totalHidden;
        int wordsToHide = random.Next(1, Math.Min(4, diff));

        while (wordsHidden < wordsToHide)
        {
            int randomIndex = random.Next(0, _wordsList.Count);

            if (!_wordsList[randomIndex].IsHidden())
            {
                _wordsList[randomIndex].Hide();
                wordsHidden++;
            }
        }
        int count = + wordsHidden;
        Console.Clear();
        GetRenderedText();
        return count;
    
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