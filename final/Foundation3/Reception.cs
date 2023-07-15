public class Reception : Event
{
    private string _mail;

    public Reception(string title, string description, string date, string time, Address address, string mail) : base  (title, description, date, time, address)
    {
        _mail = mail;
    }

    public override void FullDetails()
    {
        StandarDetails();
        Console.WriteLine($"Event: Reception\nRSVP by: {_mail}");
    }

    public override void ShortDetails()
    {
        Console.WriteLine($"Event: Reception\nTitle: {_title} - Date: {_date}");
    }
}