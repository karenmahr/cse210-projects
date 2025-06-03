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
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!\n You have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {
        
    }
}