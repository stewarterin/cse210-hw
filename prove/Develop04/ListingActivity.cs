public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    public void RunListing()
    {
        Console.Clear();

        DisplayStartMessage();
        
        Console.WriteLine("Get Ready...");
        DisplaySpinner(7);

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.WriteLine("You may begin in: ");
        DisplayCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationSeconds);
        
        List<string> userList = GetUserList(endTime);

        Console.WriteLine($"You listed {userList.Count} items!");

        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string _prompt = _prompts[index];
        return _prompt;       
    }

    public void DisplayPrompt()
    {
        string _prompt = GetRandomPrompt();
        Console.WriteLine($" --- {_prompt} --- ");
    }

    public List<string> GetUserList(DateTime endTime)
    {
        List<string> responses = new List<string>();
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userEntry = Console.ReadLine();
            responses.Add(userEntry);
        }
        return responses; 
    }
}