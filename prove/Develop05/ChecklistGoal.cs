public class ChecklistGoal : Goal
{
    private bool _complete;
    private int _numberCompleted;
    private int _targetCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, bool complete, int number, int target, int bonus) : base(name, description, points)
    {
        _complete = complete;
        _numberCompleted = number;
        _targetCompleted = target;
        _bonusPoints = bonus;
    }

    public override void GetGoal()
    {
        
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return ;
    }
}