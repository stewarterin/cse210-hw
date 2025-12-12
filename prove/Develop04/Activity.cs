public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _durationSeconds;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description; 
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _durationSeconds = int.Parse(Console.ReadLine());
        Console.Clear(); 
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"\nWell done!!");
        DisplaySpinner(7);
        Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName}.");
        DisplaySpinner(7);
        Console.Clear(); 
    }

    public void DisplaySpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }

            Console.WriteLine("\b \b"); 
    }

    public void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}