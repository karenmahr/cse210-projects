using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} \n {_description} \n How long, in seconds, would you like for your session?");
        string userInput = Console.ReadLine();
        int seconds = int.Parse(userInput);        
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!\n You have completed another {_duration} seconds of the {_name}");
    }
    
    //NOT QUITE THERE, BUT VERY CLOSE
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        foreach (string animation in animationStrings)
        {
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            Console.WriteLine($"Get ready... \n {animation}");
        }

    }
    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        Thread.Sleep(seconds);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
    }
}