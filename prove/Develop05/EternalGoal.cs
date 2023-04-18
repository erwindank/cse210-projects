public class EternalGoal : Goal
{
    public EternalGoal(string title, int pointValue) : base(title, pointValue)
    {
    }

    public override void Display()
    {
        Console.WriteLine(ToString());
    }

    public override void CheckOff()
    {
        Console.WriteLine($"{Title} cannot be checked off.");
    }

    public override string ToString()
    {
        string status = IsComplete ? "Complete" : "Incomplete";
        return $"{Title} ({PointValue} points, {status}, Eternal)";
    }
}