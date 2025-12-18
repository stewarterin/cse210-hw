using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("23 Pine Rd", "Mesa", "AZ", "USA");
        Customer c1 = new Customer("Erin Stewart", a1);
        Product p1 = new Product("Soap", 883, 2.50, 3);
        Product p2 = new Product("Dryer sheets", 593, 3.75, 1);
        Order o1 = new Order(c1);

        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Console.WriteLine($"Total = ${o1.GetCost()}");
        o1.GetShipLabel();
        o1.GetPackLabel();

        Console.WriteLine("");
        
        Address a2 = new Address("91 Bird Ave", "Toronto", "ON", "CANADA");
        Customer c2 = new Customer("Donna Lundy", a2);
        Product p3 = new Product("Chapstick", 102, 1.75, 3);
        Product p4 = new Product("Shampoo", 530, 5.00, 1);
        Product p5 = new Product("Hand Sanitizer", 979, 6.00, 4);
        Order o2 = new Order(c2);

        o2.AddProduct(p3);
        o2.AddProduct(p4);
        o2.AddProduct(p4);

        Console.WriteLine($"Total = ${o2.GetCost()}");
        o2.GetShipLabel();
        o2.GetPackLabel();
    }
}