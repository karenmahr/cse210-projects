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

    }

    public override bool IsComplete()
    {

    }

    public override string GetDetailsString()
    {

    }

    public override string GetStringRepresentation()
    {

    }
}