public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double _distanceInKm = _distance;
        double _timeInHours = (double)Length / 60;
        double _speedInKph = _distanceInKm / _timeInHours;
        return _speedInKph;
    }

    public override double GetPace()
    {
        double _distanceInKm = _distance;
        double _timeInMinutes = Length;
        double _paceInMinPerKm = _timeInMinutes / _distanceInKm;
        return _paceInMinPerKm;
    }
}
