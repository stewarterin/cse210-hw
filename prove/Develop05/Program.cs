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
            Console.WriteLine("6. Quit");
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
                SimpleGoal s1 = new SimpleGoal("SimpleT", "SimpleT", 10, true);
                s1.GetGoal();
                s1.RecordEvent();
                Console.WriteLine(s1.IsComplete());
                Console.WriteLine("____________________________");

                SimpleGoal s2 = new SimpleGoal("Simple2", "Simple2", 20, false);
                s2.GetGoal();
                s2.RecordEvent();
                Console.WriteLine(s2.IsComplete());
                Console.WriteLine("____________________________");

                EternalGoal e1 = new EternalGoal("Eternal", "Eternal", 30);
                e1.GetGoal();
                e1.RecordEvent();
                Console.WriteLine(e1.IsComplete());
                Console.WriteLine("____________________________");

                ChecklistGoal c1 = new ChecklistGoal("ChecklistT", "ChecklistT", 40, true, 1, 3, 10);
                c1.GetGoal();
                c1.RecordEvent();
                Console.WriteLine(c1.IsComplete());
                Console.WriteLine("____________________________");

                ChecklistGoal c2 = new ChecklistGoal("ChecklistF", "ChecklistF", 40, false, 3, 3, 10);
                c2.GetGoal();
                c2.RecordEvent();
                Console.WriteLine(c2.IsComplete());
                Console.WriteLine("____________________________");
                

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