public class Activity
{
    private string _activityName;
    private string _description;
    private int _durationSeconds;

    public Activity()
    {
        
    }

    public void DisplayStartMessage()
    {
        
    }

    public void DisplayEndMessage()
    {
        
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
        
        while (_durationSeconds > 0)
        {
            Console.Write($"{_durationSeconds}");
            Console.Write("\b");
            Thread.Sleep(1000);
            _durationSeconds--;
        }

        Console.WriteLine("\b");  
    }
}