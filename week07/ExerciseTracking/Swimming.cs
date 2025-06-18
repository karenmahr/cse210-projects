using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(int laps, DateTime date, string name, int length, double distance, int time)
       : base(date, name, length, distance, time)
    {
        _laps = laps;

    }

    public override double Distance()
    {
        return (_laps * 50) / 1000;
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