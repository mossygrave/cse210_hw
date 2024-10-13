public class Customer
{

    private string _name;
    private Address _address;
    private bool isUSA;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string ShippingAddress()
    {
        string fullAddress = _address.FullAddress();
        string shippingAddress = $"{_name} \n{fullAddress}";

        return shippingAddress;
    }

    public bool IsUSA()
    {
        isUSA = _address.CheckUSA();

        return isUSA;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine(_name);
        _address.DisplayAddress();
    }
}