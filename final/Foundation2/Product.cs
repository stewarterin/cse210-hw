public class Product
{
    private string _productName;
    private int _id;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, int price, int quantity)
    {
        _productName = name;
        _id = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public int GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

}