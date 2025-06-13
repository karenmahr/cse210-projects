using System;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(int score)
    {
        _score = score;
    } 

    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu:");
        string userInput = Console.ReadLine();
        int option = int.Parse(userInput);
        Console.WriteLine();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }
    }
    public void CreateGoal(Goal newGoal)
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to create?");
        string seconduserInput = Console.ReadLine();
        int secondOption = int.Parse(seconduserInput);
        Console.WriteLine();

        Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it?");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        string thirduserInput = Console.ReadLine();
        int goal = int.Parse(thirduserInput);
        Console.WriteLine();

        Goal newGoal = null;
        if (secondOption == 1)
        {
            newGoal = new SimpleGoal(name, description, points);
        }

        else if (secondOption == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }

        else if (secondOption == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            string fourthduserInput = Console.ReadLine();
            int times = int.Parse(fourthduserInput);
            Console.WriteLine();

            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            string fifthuserInput = Console.ReadLine();
            int bonus = int.Parse(fifthuserInput);
            Console.WriteLine();

            newGoal = new CheckListGoal(name, description, points, times, bonus);
        }
        if (newGoal != null)
        {
            _goals.Add(newGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish? ");
        string userInput = Console.ReadLine();
        int recordingEvent = int.Parse(userInput);
        Console.WriteLine($"You have {points} points.");
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }
}