public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathing()
    {
        DisplayStartMessage();

        Console.WriteLine("Get Ready...");
        DisplaySpinner();
        Console.Write("\nBreathe in...");
        DisplayCountdown(4);
        Console.Write("Now breathe out...");
        DisplayCountdown(4);

    }
}