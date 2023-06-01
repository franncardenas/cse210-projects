public class Assignment
{
    //Attributes
    private string _studentName ;
    private string _topic;

    //Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Method or Behaviors
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}