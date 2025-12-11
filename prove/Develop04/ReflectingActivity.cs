public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "",
        "",
        ""        
    };
    private List<string> _questions = new List<string>
    {
        "",
        "",
        ""       
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    public void RunReflecting()
    {
        Console.Clear();

        DisplayStartMessage();
        
        Console.WriteLine("Get Ready...");
        DisplaySpinner();
        Console.WriteLine("Consider the following prompt:");
        
        string prompt = _prompts.GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they realted to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationSeconds);

        Console.Clear();
        
        while (DateTime.Now < endTime)
        {
            string question = _questions.GetRandomQuestion();
            Console.WriteLine($"> {question} ");
            DisplaySpinner(10);
        }

        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        // return ;
    }

    public string GetRandomQuestion()
    {
        // return ;
    }

    public void DisplayPrompt()
    {
        
    }

    public void DisplayQuestion()
    {
        
    }
}