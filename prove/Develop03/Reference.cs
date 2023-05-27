class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    //Constructors
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    
    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    //Behaviors
    public string GetReference()
    {   
        if (_endVerse is null)
        {
           string referenceOne = _book + ' ' + _chapter+ ':' + _verse;
           return referenceOne;
        }
        else
        {
            string allReference = _book + ' ' + _chapter+ ':' + _verse + '-' + _endVerse;
            return allReference;
        } 
    }
}