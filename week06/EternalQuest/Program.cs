using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to EternalQuest!");

        GoalManager manager = new GoalManager(0);
        manager.Start();
    }
    
}