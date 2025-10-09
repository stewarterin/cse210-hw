using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        while (userInput != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please sselect one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
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
            else if (userInput == 4)
            {

            }
            else
            {
                
            }
        }
    }
}