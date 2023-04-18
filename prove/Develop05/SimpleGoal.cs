public class SimpleGoal : Goal
{
    private bool _isCheckedOff;

    public SimpleGoal(string title, int pointValue) : base(title, pointValue)
    {
        _isCheckedOff = false;
    }

    public bool IsCheckedOff
    {
        get { return _isCheckedOff; }
        set { _isCheckedOff = value; }
    }

    public override void Display()
    {
        Console.WriteLine(ToString());
    }

    public override void CheckOff()
    {
        if (!_isCheckedOff)
        {
            _isCheckedOff = true;
            IsComplete = true;
            Console.WriteLine($"{Title} has been checked off!");
        }
        else
        {
            Console.WriteLine($"{Title} has already been checked off.");
        }
    }

    public override string ToString()
    {
        string status = IsComplete ? "Complete" : "Incomplete";
        string checkOffStatus = _isCheckedOff ? "Checked Off" : "Not Checked Off";
        return $"{Title} ({PointValue} points, {status}, {checkOffStatus})";
    }
}