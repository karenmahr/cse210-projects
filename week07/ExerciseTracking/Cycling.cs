using System;

public class Cycling: Activity
{
    private double _speed;
    private double _pace;
    public Cycling(DateTime date, string name, int time, int length, double distance, double pace, double speed)
       : base(date, name, length, distance, time)
    {
        _pace = pace;
        _speed = speed;
    }
    public override double Distance()
    {
        return (_speed * GetTime()) / 60;
    }

    public override double Speed()
    {
        return _speed;

    }

    public override double Pace()
    {
        return 60 / _pace;
    }
}