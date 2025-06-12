using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(bool isComplete, string shortName, string description, string points)
      : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }
  public override void RecordEvent()
  {
    if (!_isComplete)
    {
      _isComplete = true;
      Console.WriteLine($"Congratulations! You earned {GetPoints()} points.");
    }
    else
    {
      Console.WriteLine("This goal is already completed.");
    }
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }
  public override string GetStringRepresentation()
  {
    string checkbox = _isComplete ? "[X]" : "[ ]";
    return $"{checkbox} {GetShortName()} ([_description])";
  }
}