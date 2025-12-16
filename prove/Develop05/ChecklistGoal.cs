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
        if (_numberCompleted == _targetCompleted)
        {
            Console.WriteLine($"[X] {_goalName} ({_description}) -- Currently completed: {_numberCompleted}/{_targetCompleted}");
        }
        else
        {
            Console.WriteLine($"[ ] {_goalName} ({_description}) -- Currently completed: {_numberCompleted}/{_targetCompleted}");
        }
    }

    public override int RecordEvent()
    {
        if (_numberCompleted == (_targetCompleted - 1))
        { 
           Console.WriteLine($"Congratulations! You have earned {_points + _bonusPoints} points!"); 
                      
           Console.Write($"That includes {_bonusPoints} bonus points! \n");
           
           List<string> animationString = new List<string>();
            animationString.Add("|");
            animationString.Add("/");
            animationString.Add("-");
            animationString.Add("\\");
            animationString.Add("|");
            animationString.Add("/");
            animationString.Add("-");
            animationString.Add("\\");

            foreach (string s in animationString)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            return _points + _bonusPoints;
        }
        else
        {
            _numberCompleted++;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");

            return _points;
        }

    }

    public override bool IsComplete()
    {
        if (_numberCompleted == _targetCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public override string GetDetails()
    {
        return $"ChecklistGoal~~{_goalName}~~{_description}~~{_points}~~{_complete}~~{_numberCompleted}~~{_targetCompleted}~~{_bonusPoints}";
    } 
}