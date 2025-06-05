using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"Get ready...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ;
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            Console.WriteLine();
        }  

        Console.WriteLine("Well done!!");
        ShowSpinner(3);                             
        DisplayEndingMessage();  
    }
}