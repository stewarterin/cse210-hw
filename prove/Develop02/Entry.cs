public class Entry
{
    public string _date;

    public string _prompt;

    public string _text;
    public void Display()
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_text}");
    }
}