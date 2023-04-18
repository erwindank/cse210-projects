using System;
using System.Collections.Generic;

public abstract class Goal
{
    private string _title;
    private int _pointValue;
    private int _timesCompleted;
    private bool _isComplete;

    public Goal(string title, int pointValue)
    {
        _title = title;
        _pointValue = pointValue;
        _timesCompleted = 0;
        _isComplete = false;
    }

    public string Title
    {
        get { return _title; }
    }

    public int PointValue
    {
        get { return _pointValue; }
    }

    public int TimesCompleted
    {
        get { return _timesCompleted; }
        set { _timesCompleted = value; }
    }

    public bool IsComplete
    {
        get { return _isComplete; }
        set { _isComplete = value; }
    }

    public abstract void Display();

    public abstract void CheckOff();

    public override string ToString()
    {
        string status = _isComplete ? "Complete" : "Incomplete";
        return $"{_title} ({_pointValue} points, {status})";
    }
}