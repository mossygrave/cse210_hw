public class Product
{

    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double ProductTotal()
    {
        double productTotal = _quantity * _price;

        return productTotal;
    }

    public string PackingInfo()
    {
        string packingInfo = $"Name: {_name} Product ID: {_id}";

        return packingInfo;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Name: {_name} Product ID: {_id} Price: {_price} Quantity: {_quantity}");
    }
}