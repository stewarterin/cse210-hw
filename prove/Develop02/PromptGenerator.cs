public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "What are two things I'm grateful for today?",
        "What did I do today that I'm proud of?",
        "What was the hardest part of my day?"
    };

    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Nexwt(_prompts.Count);
        
        return 
    }
}