public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
    }

    public abstract void GetGoal();

    public abstract void RecordEvent();

    public abstract bool IsComplete();
}