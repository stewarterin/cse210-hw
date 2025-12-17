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
    }
}