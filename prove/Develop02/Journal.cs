using System;
using System.Collections.Generic;
using System.IO;

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
    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Your file has been saved. ");
    }
}