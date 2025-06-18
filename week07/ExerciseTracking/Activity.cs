using System;

public abstract class Activity
{
    private DateTime _date;
    private string _name;
    private int _length;
    private double _distance;
    private double _time;

    public Activity(DateTime date, string name, int length, double distance, double time)
    {
        _date = date;
        _name = name;
        _length = length;
        _distance = distance;
        _time = time;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public double GetTime()
    {
        return _time;
    }
    protected DateTime GetDate()
    {
        return _date;
    }
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_name} ({_time} min) - Distance: {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }
            
}