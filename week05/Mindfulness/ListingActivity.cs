using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description, duration)
    {
        _count = count;
        _prompts = new List<string>();
    }
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {

    }
    //GetListFromUser(): List <string>
}