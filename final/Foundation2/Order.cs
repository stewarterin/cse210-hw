using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public int GetCost()
    {
        int _finalCost = 0;
        
        foreach (Product product in _products)
        {
            product.GetTotalCost();
        }

        if (_customer.InUSA() == true)
        {
            _finalCost += 5;
        }
        else
        {
            _finalCost += 35;
        }
        return _finalCost; 
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void GetShipLabel()
    {

    }

    public void GetPackLabel()
    {

    }
}