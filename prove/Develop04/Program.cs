using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;

        while (userInput != 4)
        {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");

        userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
            {
                
            }
        else if (userInput == 2)
            {
                
            }
        else if (userInput == 3)
            {
                
            }
        else
            {
                Environment.Exit(0);
            }
        }
    }
}