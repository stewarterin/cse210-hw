using System;
using System.Collections.Generic;

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

    public string _prompt;
    
    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        _prompt = _prompts[index];
        return _prompt;
    }

    public void UserPrompt(string _userPrompt)
    {
        _prompts.Add(_userPrompt);
    }
}