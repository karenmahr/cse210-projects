using System;
//I exceeded the requirements in the method GetRandomPrompt() in the ListingActivity class.
//I used the Fisher-Yates shuffle to display the prompts without being repeated.
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
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(3);

        List<string> userEntries = GetListFromUser();
        
        Console.WriteLine();
        Console.WriteLine($"You listed {userEntries.Count} items!");
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        ShowSpinner(3);
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
{
    List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    Random random = new Random();

    for (int i = 0; i < _prompts.Count; i++)
    {
        int randomIndex = random.Next(i, _prompts.Count); 
        string temp = _prompts[i];
        _prompts[i] = _prompts[randomIndex];
        _prompts[randomIndex] = temp;
    }

    foreach (string prompt in _prompts)
    {
        Console.WriteLine(prompt);
        Console.ReadLine();
    }
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