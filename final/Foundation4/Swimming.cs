using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Length / 60.0);
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        string _summary = $"{Date.ToString("dd MMM yyyy"):d} Swimming ({Length} min)- ";
        _summary += $"Distance {GetDistance():F1} km, ";
        _summary += $"Speed {GetSpeed():F1} kph, ";
        _summary += $"Pace: {GetPace():F1} min per km";
        return _summary;
    }
}
