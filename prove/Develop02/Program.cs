//To show creativity and exceed the core requirements,
//I added an option for the user to do a "free write" without a prompt.
//I also added an option for the user to add their own prompt to the list of prompts.

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
        
        while (userInput != 7)
        {
            Console.WriteLine("───────────────────────────────");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please sselect one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Free Write");
            Console.WriteLine("3. Add Prompt");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Save");
            Console.WriteLine("7. Quit");
            Console.Write("What would you like to do? ");

            userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("───────────────────────────────");

            if (userInput == 1)
            {
                j1.AddEntry();
            }
            else if (userInput == 2)
            {
                j1.AddFree();
            }
            else if (userInput == 3)
            {
                j1.AddPrompt();
            }
            else if (userInput == 4)
            {
                j1.DisplayJournal();
            }
            else if (userInput == 5)
            {
                j1.Load();
            }
            else if (userInput == 6)
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