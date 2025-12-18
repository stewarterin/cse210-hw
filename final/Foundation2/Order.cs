using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double GetCost()
    {
        double _finalCost = 0;
        
        foreach (Product product in _products)
        {
            _finalCost += product.GetTotalCost();
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
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress()}");
    }

    public void GetPackLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetProductName()} - Id: {product.GetId()}");
        }
    }
}