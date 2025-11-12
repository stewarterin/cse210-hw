using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal j1 = new Journal();
        int userInput = -1;
        while (userInput != 5)
        {
            Console.WriteLine("───────────────────────────────");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please sselect one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("───────────────────────────────");
            
            if (userInput == 1)
            {
                j1.AddEntry();
            }
            else if (userInput == 2)
            {
                j1.DisplayJournal();
            }
            else if (userInput == 3)
            {
                
            }
            else if (userInput == 4)
            {
                j1.Save();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}