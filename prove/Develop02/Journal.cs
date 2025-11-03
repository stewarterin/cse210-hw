public class Journal
{
    public void AddEntry(Entry newEntry)
    {
        PromptGenerator p1 = new PromptGenerator();
        string prompt = p1.RandomPrompt();

        Console.WriteLine($"{prompt}");
        Console.WriteLine(">");

    }
}