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
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, prompts.Length);

        return prompts[index];
    }
    public string GetRandomQuestions()
    {
        string[] questions ={
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, questions.Length);

        return questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(_prompts);
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(_questions);
    }
}