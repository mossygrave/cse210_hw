public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    
    public bool CheckUSA()
    {
        bool IsUSA = false;
        if (_country == "USA")
        {
            IsUSA = true;
        }

        return IsUSA;
    }

    public string FullAddress()
    {
        string fullAddress = $"{_streetAddress} \n{_city}, {_state} {_country}";

        return fullAddress;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}, {_state} {_country}");
    }
}