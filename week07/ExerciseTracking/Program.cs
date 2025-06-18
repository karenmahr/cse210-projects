using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running r1 = new Running(new DateTime(2022, 11, 3), "Running", 30, 4, 20);
        activities.Add(r1);

        Cycling c1 = new Cycling(new DateTime (04 / 11 / 2023), "Cycling", 20, 8, 20);
        activities.Add(c1);

        Swimming s1 = new Swimming(20,new DateTime(20, 01 / 05 / 2020), "Swimming", 50, 2, 20);
        activities.Add(s1);

        foreach (Activity activity in activities)
        {
           Console.WriteLine (activity.GetSummary());
        }   
    }
}