public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date; 
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandarDetails()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nInformation: {_date} - {_time}, Address: {_address.GetAddress()}");
    }

    public abstract void FullDetails();

    public abstract void ShortDetails();
    
}