//To show creativity and exceed the core requirements, in the ChecklistGoal class, 
//I added a message and an animation (spinner) to display in celebration of when
//bonus points are earned. The message states the amount of bonus points awarded. 

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker g1 = new GoalTracker();
        int userInput = -1;

        Console.WriteLine("Welcome to the Eternal Quest Program!");

        while (userInput !=6)
        {
            Console.WriteLine("───────────────────────────────");
            Console.WriteLine($"You have {g1._totalPoints} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("───────────────────────────────");

            if (userInput == 1)
            {
                g1.CreateNewGoal();          
            }
            else if (userInput == 2)
            {
                g1.DisplayGoals();
            }
            else if (userInput == 3)
            {
                g1.SaveGoals();
            }
            else if (userInput == 4)
            {
                g1.LoadGoals();
            }
            else if (userInput == 5)
            {
                g1.Record();
            }
            else 
            {
                Environment.Exit(0);
            }
        }
    }
}