public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string CustomerInformation()
    {   
        string fulladdress = _address.GetFullAddress();
        return $"{_name}\n{fulladdress}";
    }
    
    public bool VerifyCountry()
    {
        return _address.IsInUSA();
    }
}