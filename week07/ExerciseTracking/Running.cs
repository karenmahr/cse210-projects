using System;

public class Running : Activity
{
    public Running(DateTime date, string name, int length, int distance, int time)
       : base(date, name, length, distance, time)
    {

    }

    public override int Distance()
    {
        return GetDistance();
    }

    public override int Speed()
    {
        return (GetDistance() / GetTime()) * 60;
    }

    public override int Pace()
    {
        return GetTime() / GetDistance();
    }
}