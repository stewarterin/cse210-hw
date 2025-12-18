using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("23 Pine Rd", "Mesa", "AZ", "USA");
        Console.WriteLine(a1.DisplayAddress());
        Console.WriteLine(a1.GetCountry());

        Address a2 = new Address("91 Bird Ave", "Toronto", "ON", "CANADA");
        Console.WriteLine(a2.DisplayAddress());
        Console.WriteLine(a2.GetCountry());

        Customer c1 = new Customer("Erin Stewart", a1);
        Console.WriteLine(c1.InUSA());
        Console.WriteLine(c1.GetName());
        Console.WriteLine(c1.GetAddress());

        Product p1 = new Product("Soap", 883, 2.50, 3);
        Console.WriteLine(p1.GetTotalCost());
        Console.WriteLine(p1.GetProductName());
        Console.WriteLine(p1.GetId());
    }
}