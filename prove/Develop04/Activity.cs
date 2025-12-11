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
        DisplaySpinner();
        Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName}.");
        DisplaySpinner();
        Console.Clear(); 
    }

    public void DisplaySpinner()
    {
        for (int i = 0; i < 7; i++)
            {
                Console.Write(". ");

                Thread.Sleep(500);
            }

        Console.WriteLine("\b \b \b \b");  
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