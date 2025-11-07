public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        PromptGenerator p1 = new PromptGenerator();
        string prompt = p1.RandomPrompt();

        Console.WriteLine($"{prompt}");
        Console.Write("> ");
        string userEntry = Console.ReadLine();

        Entry e1 = new Entry
        {
            _prompt = prompt,
            _text = userEntry
        };
        
        _entries.Add(e1);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}