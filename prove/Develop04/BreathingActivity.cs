public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public void RunBreathing()
    {
        Console.Clear();

        DisplayStartMessage();
        
        Console.WriteLine("Get Ready...");
        DisplaySpinner();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationSeconds);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            DisplayCountdown(5);
            Console.Write("\nNow breathe out...");
            DisplayCountdown(5);
            Console.WriteLine("");
        }

        DisplayEndMessage();
    }
}