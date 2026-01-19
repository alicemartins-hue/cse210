using System;
using System.Collections.Generic;


public class PromptGenerator
{

    public List<string> _prompts = new List<string>()
    {
        "How was the weather today? ",
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today? "
    };

    private Random _random = new Random();


    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];

    }
}