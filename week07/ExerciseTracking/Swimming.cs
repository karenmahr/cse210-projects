using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(int laps, DateTime date, string name, int length, int distance, int time)
       : base(date, name, length, distance, time)
    {
        _laps = laps;

    }

    public override int Distance()
    {
        return (_laps * 50) / 1000;
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