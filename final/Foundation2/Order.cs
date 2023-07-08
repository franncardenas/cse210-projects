public class Order
{
    private Customer _customer;
    private List<Product> _productList= new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _productList)
        {
            totalCost += product.CalculateTotalPrice();
        }

        if (_customer.VerifyCountry())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        int count=0;
        foreach (Product product in _productList)
        {
            count++;
            Console.WriteLine($"Product {count}: {product.GetProductName()}, {product.GetProductID()}");
        }
    }
    
    public void ShippingLabel()
    {
        string fullInformation = _customer.CustomerInformation();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{fullInformation}");
    }


}