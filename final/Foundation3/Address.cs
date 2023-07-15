public class Address
{
    private string _street;

    public Address(string street)
    {
        _street = street;
    }

    public string GetAddress()
    {
        return $"{_street}";
    }
}