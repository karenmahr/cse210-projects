using System;

public abstract class Activity
{
    private DateTime _date;
    private string _name;
    private int _length;
    private int _distance;
    private int _time;

    public Activity(DateTime date, string name, int length, int distance, int time)
    {
        _date = date;
        _name = name;
        _length = length;
        _distance = distance;
        _time = time;
    }

    public int GetDistance()
    {
        return _distance;
    }
    public int GetTime()
    {
        return _time;
    }

    protected DateTime GetDate()
    {
        return _date;
    }


    public abstract int Distance();
    public abstract int Speed();
    public abstract int Pace();

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_name} ({_time} min) - Distance: {_distance} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }
            
}