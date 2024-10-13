using System;

class Program
{
    static void Main(string[] args)
    {
        //create 2 orders with 2-3 products each and display them

        Address address1 = new Address("123 Street St", "City", "State", "USA");
        Customer customer1 = new Customer("Jane Doe", address1);

        Address address2 = new Address("456 Main St", "City", "Province", "Canada");
        Customer customer2 = new Customer("John Smith", address2);

        Product product1 = new Product("Milk", "27AB", 2.99, 3);
        Product product2 = new Product("Eggs", "33DF", 1.99, 2);
        Product product3 = new Product("Chips", "14GH", 3.50, 1);
        Product product4 = new Product("Shampoo", "67HF", 14.99, 1);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);

        List<Product> products2 = new List<Product>();
        products2.Add(product4);
        products2.Add(product2);

        Order order1 = new Order(products1, customer1);

        Order order2 = new Order(products2, customer2);

        string packingLabel = order1.PackingLabel();
        Console.WriteLine($"Packing Label: {packingLabel}");
        Console.WriteLine();

        string shippingLabel = order1.ShippingLabel();
        Console.WriteLine($"Shipping Label: {shippingLabel}");
        Console.WriteLine();

        double orderTotal = order1.OrderTotal();
        Console.WriteLine($"Order Total: {orderTotal}");
        Console.WriteLine();

        string packingLabel2 = order2.PackingLabel();
        Console.WriteLine($"Packing Label: {packingLabel2}");
        Console.WriteLine();

        string shippingLabel2 = order2.ShippingLabel();
        Console.WriteLine($"Shipping Label: {shippingLabel2}");
        Console.WriteLine();

        double orderTotal2 = order2.OrderTotal();
        Console.WriteLine($"Order Total: {orderTotal2}");
        Console.WriteLine();
    }
}