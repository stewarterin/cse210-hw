public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(bool complete) : base(name, description, points)
    {
        
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