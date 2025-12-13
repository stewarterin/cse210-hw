//To show creativity and exceed the core requirements, 
//I added another menu option (option 4). This option 
//lets the computer randomly selects and runs one of the 
//mindfulness activities.

using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;

        while (userInput != 5)
        {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Select random activity");
        Console.WriteLine("5. Quit");
        Console.Write("Select a choice from the menu: ");

        userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.RunBreathing();
            }
        else if (userInput == 2)
            {
                ReflectingActivity r1 = new ReflectingActivity();
                r1.RunReflecting();
            }
        else if (userInput == 3)
            {
                ListingActivity s1 = new ListingActivity();
                s1.RunListing();
            }   
        else if (userInput == 4)
            {
                RandomActivity n1 = new RandomActivity();
                n1.RunRandomActivity();
            }
        else 
            {
                Environment.Exit(0);
            }
        }
    }
}