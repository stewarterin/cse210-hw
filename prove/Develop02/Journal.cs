public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        PromptGenerator p1 = new PromptGenerator();
        string prompt = p1.RandomPrompt();

        Console.WriteLine($"{prompt}");
        Console.WriteLine(">");
        string userEntry = Console.ReadLine();

    }
    
}