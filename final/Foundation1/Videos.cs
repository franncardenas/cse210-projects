public class Video
{
    private string _title;
    private string _autor;
    private int _duration;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string autor, int duration)
    {
        _title = title;
        _autor = autor;
        _duration = duration;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {_title}, Autor: {_autor}, Duration: {_duration}");
    }

    public void ShowComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.ShowComment();
        }
    }
}