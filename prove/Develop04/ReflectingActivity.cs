public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless"        
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"     
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    public void RunReflecting()
    {
        Console.Clear();

        DisplayStartMessage();
        
        Console.WriteLine("Get Ready...");
        DisplaySpinner(7);
        Console.WriteLine("\nConsider the following prompt:");
        
        DisplayPrompt();
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
            DisplayQuestion();
            DisplaySpinner(15);
        }

        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string _prompt = _prompts[index];
        return _prompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string _question = _questions[index];
        return _question;
    }

    public void DisplayPrompt()
    {
        string _prompt = GetRandomPrompt();
        Console.WriteLine($" --- {_prompt} --- ");
    }

    public void DisplayQuestion()
    {
        string _question = GetRandomQuestion();
        Console.Write($"> {_question} ");    
    }
}