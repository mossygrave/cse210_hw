public class Order
{

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;

        foreach (Product product in products)
        {
            _products.Add(product);
        }
    }
    
    public double OrderTotal()
    {
        double total = 0;
        bool isUSA = _customer.IsUSA();

        foreach (Product product in _products)
        {
            double price = product.ProductTotal();
            total += price;
        }

        if (isUSA == false)
        {
            total += 35;
        }
        else 
        {
            total += 5;
        }

        total = Math.Round(total, 2);
        
        return total;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.PackingInfo() + " ";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = _customer.ShippingAddress();

        return shippingLabel;
    }

    public void DisplayOrder()
    {
        _customer.DisplayCustomer();
        
        foreach (Product product in _products)
        {
            product.DisplayProduct();
        }
    }
}