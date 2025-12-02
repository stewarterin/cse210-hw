using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John", 3, 16);
        Console.WriteLine(r1.GetReference());

        Reference r2 = new Reference("John", 3, 16, 17);
        Console.WriteLine(r2.GetReference());
    }
}