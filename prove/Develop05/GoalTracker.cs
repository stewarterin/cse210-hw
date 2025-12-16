using System;
using System.Collections.Generic;
using System.IO;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>
    {   
    };

    public int _totalPoints = 0;

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
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetDetails());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
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

    public void Record()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].GetGoal();
        }

        Console.Write("Which goal did you accomplish? "); 
        
        int goalNumber = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("───────────────────────────────");

        Goal goal = _goals[goalNumber];

        int newPoints = goal.RecordEvent();
        _totalPoints += newPoints;
    }
}