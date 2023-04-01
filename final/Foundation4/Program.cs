using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some activities
        Running _run = new Running(new DateTime(2022, 11, 3), 20, 4.0);
        Cycling _cycle = new Cycling(new DateTime(2022, 11, 4), 45, 10.0);
        Swimming _swim = new Swimming(new DateTime(2022, 11, 5), 30, 20);

        // Add the activities to a list
        List<Activity> _activities = new List<Activity>();
        _activities.Add(_run);
        _activities.Add(_cycle);
        _activities.Add(_swim);

        // Iterate over the activities and print the summaries
        foreach (Activity _activity in _activities)
        {
            Console.WriteLine(_activity.GetSummary());
        }
    }
}
