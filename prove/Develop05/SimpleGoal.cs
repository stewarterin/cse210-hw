public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
    {
        _complete = complete;
    }

    public override void GetGoal()
    {
        if (_complete == true)
        {
            Console.WriteLine($"[X] {_goalName} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_goalName} ({_description})");
        }  
    }

    public override void RecordEvent()
    {
        _complete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _complete;
    }

    public override string GetDetails()
    {
        return $"SimpleGoal~~{_goalName}~~{_description}~~{_points}~~.{_complete}";
    } 
}