public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double _speedInKph = _speed;
        double _timeInHours = (double)Length / 60;
        double _distanceInKm = _speedInKph * _timeInHours;
        return _distanceInKm;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double _speedInKph = _speed;
        double _paceInMinPerKm = 60 / _speedInKph;
        return _paceInMinPerKm;
    }
}
