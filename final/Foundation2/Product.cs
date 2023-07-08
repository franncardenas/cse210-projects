public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productname, string productId, double price, int quantity)
    {
        _productName = productname;
        _productID = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }
    public double CalculateTotalPrice()
    {
        return _price * _quantity;
    }
}