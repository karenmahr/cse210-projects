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

    }

    public override bool IsComplete()
    {

    }

    public override string GetStringRepresentation()
    {

    }
}