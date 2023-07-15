public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base  (title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void FullDetails()
    {
        StandarDetails();
        Console.WriteLine($"Event: Outdoor Gathering\nWeather: {_weather}");
    }

    public override void ShortDetails()
    {
        Console.WriteLine($"Event: Outdoor Gathering\nTitle: {_title} - Date: {_date}");
    }

}