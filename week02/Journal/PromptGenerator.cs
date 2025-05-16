using System;

public class PromptGenerator
{  
    public List <string> _prompts = new List<string>()
    {
        "From one to ten, how did your day looked like?",
        "What was the strongest emotion you felt today",
        "How did you felt the Spirit today?",
        "What is something you want to do better tomorrow?",
        "What is something you are grateful for today?"
    };    
      Random _random = new Random();  
      public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];      
    }

}