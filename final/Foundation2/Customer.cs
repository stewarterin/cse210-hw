public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool InUSA()
    {
        return _address.GetCountry(); 
    }
}