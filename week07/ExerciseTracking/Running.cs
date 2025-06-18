using System;

public class Running : Activity
{
    public Running(DateTime date, string name, int length, double distance, double time)
       : base(date, name, length, distance, time)
    {

    }

    public override double Distance()
    {
        return GetDistance();
    }

    public override double Speed()
    {
        return (GetDistance() / GetTime()) * 60;
    }

    public override double Pace()
    {
        return GetTime() / GetDistance();
    }
}