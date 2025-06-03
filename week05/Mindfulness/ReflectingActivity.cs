using System;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {

    }
    public string GetRandomQuestions()
    {

    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {
        
    }
}