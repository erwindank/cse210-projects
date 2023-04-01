public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public int Length
    {
        get { return _length; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string summary = $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_length} min)- Distance {GetDistance().ToString("0.0")} km, Speed {GetSpeed().ToString("0.0")} kph, Pace: {GetPace().ToString("0.0")} min per km";
        return summary;
    }
}
