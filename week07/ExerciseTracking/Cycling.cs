using System;

public class Cycling: Activity
{
    private int _speed;
    private int _pace;
    public Cycling(DateTime  date, string name, int time, int length, int distance)
       : base(date, name, time, length, distance)
    {


    }
    public override int Distance()
    {
        return (_speed * GetTime()) / 60;
    }

    public override int Speed()
    {
        return _speed;

    }

    public override int Pace()
    {
        return 60 / _pace;
    }
}