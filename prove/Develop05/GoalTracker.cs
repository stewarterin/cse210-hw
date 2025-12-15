using System;
using System.Collections.Generic;
using System.IO;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>
    {   
    };

    public void CreateNewGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? "); 
        
        int goalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("───────────────────────────────");

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        
        if (goalNumber == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points, false));
        }
        else if (goalNumber == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalNumber == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, false, 0, target, bonus));
        }
    }
    
    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            goal.GetGoal();
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal s)
                {
                    outputFile.WriteLine($"SimpleGoal~~{s._goalName}~~{s._description}~~{s._points}~~{s._complete}");
                }
                else if (goal is EternalGoal e)
                {
                    outputFile.WriteLine($"EternalGoal~~{e._goalName}~~{e._description}~~{e._points}");
                }
                else if (goal is ChecklistGoal c)
                {
                    outputFile.WriteLine($"ChecklistGoal~~{c._goalName}~~{c._description}~~{c._points}~~{c._complete}~~{c._numberCompleted}~~{c._targetCompleted}~~{c._bonusPoints}");
                }
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, description, points, complete));
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);
                int number = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                int bonus = int.Parse(parts[7]);
                _goals.Add(new ChecklistGoal(name, description, points, complete, number, target, bonus));
            }
        }
    }
}