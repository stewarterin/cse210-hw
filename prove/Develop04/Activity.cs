public class Activity
{
    private string _activityName;
    private string _description;
    private int _durationSeconds;

    public Activity(string name, string description, int seconds)
    {
        _activityName = name;
        _description = description;
        _durationSeconds = seconds;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _durationSeconds = int.Parse(Console.ReadLine());
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done!!");
        DisplaySpinner();
        Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName}.");
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
        _durationSeconds = seconds;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            Console.Write($"{_durationSeconds}");
            Console.Write("\b");
            Thread.Sleep(1000);
            _durationSeconds--;
        }
    }
}