using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, string points, int target, int bonus)
      : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

  public override void RecordEvent()
  {
    if (_amountCompleted < _target)
    {
      _amountCompleted++;
      int totalPoints = _points;

      if (_amountCompleted == _target)
      {
        totalPoints += _bonus;
        Console.WriteLine($"Congratulations! You completed the checklist and earned a bonus of {_bonus} points.");
      }

      Console.WriteLine($"Good job! You earned {totalPoints}");
    }

    else
    {
      Console.WriteLine("This checklist goal has already been completed.");
    }
    }

  public override bool IsComplete()
  {
    return _amountCompleted>=_target;
  }

  public override string GetDetailsString()
  {
    return $"ChecklistGoal / {GetShortName()} / {GetDescription()} / {GetPoints()} / {_target} / {_bonus} / {_amountCompleted}";
    }

  public override string GetStringRepresentation()
  {
    string checkbox = IsComplete() ? "[X]" : "[ ]";
    return $"{checkbox} {GetShortName()} ([_description]) -- Completed {_amountCompleted}/{_target}";
  }
}
