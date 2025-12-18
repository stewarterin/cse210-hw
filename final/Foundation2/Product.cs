public class Product
{
    private string _productName;
    private int _id;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _id = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetId()
    {
        return _id;
    }
}