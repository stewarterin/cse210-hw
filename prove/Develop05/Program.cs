using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;

        while (userInput !=6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");                
            }
            else if (userInput == 2)
            {
                
            }
            else if (userInput == 3)
            {
                
            }
            else if (userInput == 4)
            {
                
            }
            else if (userInput == 5)
            {
                
            }
            else 
            {
                Environment.Exit(0);
            }
        }
    }
}