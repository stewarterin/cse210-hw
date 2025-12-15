public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;

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