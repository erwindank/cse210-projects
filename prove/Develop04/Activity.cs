using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    private string _activityType;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    public string ActivityType()
    {
        string _activityType = "";

        if (_name == "_breathing")
        {   
            _activityType = "Breathing Activity";
        }
        else if (_name == "_reflecting")
        {
            _activityType = "Reflecting Activity";
        }
        else if (_name == "_listing")
        {
            _activityType = "Listsing Activity";
        }

        return _activityType;

    }

    public void SetDuration()
    {
        ActivityType();
        Console.Write($"How long do you want your {_activityType} Session to last? (In seconds):");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int duration))
        {
            this._duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Duration not set.");
        }
    }

    public virtual void DoActivity()
    {
        Console.WriteLine($"{_name}: {_description}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Get ready to begin...");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        Console.Write(" ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public virtual void SpinnerAnimation()
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        
        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void CountdownTimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("\nTime's up!");
    }
    protected void ClosingMessage()
    {
        Console.WriteLine($"Good job! You completed the activity for {_duration} seconds.");
        Pause(5);
    }
}
