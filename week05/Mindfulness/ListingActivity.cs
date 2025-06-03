using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description, duration)
    {
        _count = count;
    }
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, prompts.Length);
    }
    //GetListFromUser(): List <string>
}