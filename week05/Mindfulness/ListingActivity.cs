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
        DisplayStartingMessage();

        Console.WriteLine($"Get ready...");
        ShowSpinner(3);

        Console.WriteLine($"List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(3);

        List<string> userEntries = GetListFromUser();
        
        Console.WriteLine($"You listed {userEntries.Count} items!");
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        DisplayEndingMessage();
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

        Console.WriteLine(prompts[index]);
        string answer = Console.ReadLine();
    }
    public List<string> GetListFromUser()
    {
        List<string> entries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            entries.Add(input);
        }
        return entries;
    }   
}