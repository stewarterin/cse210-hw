using System.Runtime.CompilerServices;

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
        foreach (Goal goal in _goals)
        {
            goal.GetGoal();
        }
    }

    public void SaveGoals()
    {
        
    }

    public void LoadGoals()
    {
        
    }
}