public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void GetGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_description})");
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetails()
    {
        return $"EternalGoal~~{_goalName}~~{_description}~~{_points}";
    } 
}