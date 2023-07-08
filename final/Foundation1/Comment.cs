public class Comment
{
    private string _name;
    private string _text;

    //Constructor
    public Comment(string name,string text)
    {
        _name = name;
        _text = text;
    }

    public void ShowComment()
    {
        Console.WriteLine($"Name: {_name}, Comment: {_text}");
    }
}