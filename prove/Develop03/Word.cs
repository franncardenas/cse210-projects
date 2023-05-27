class Word
{
    private string _word;
    private bool _isShow=true;

    //Constructor
    public Word(string word)
    {
        _word = word;
        _isShow = true;
    }

    //Behaviors
    public void Hide()
    {
        _isShow = false;
    }
    
    public void Show()
    {
        _isShow = true;
    }

    public bool IsHidden()
    {
        return !_isShow;
    }

    public string GetWord()
    {   
        if (_isShow)
        {
            return _word;
        }
        else
        {
            string hideWord = new string('_', _word.Length);
            return hideWord;
        }
    }
}