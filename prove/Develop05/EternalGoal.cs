class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // constructor logic for the EternalGoal subclass
        // this could include setting any additional properties specific to this type of goal
    }

    public override void IsComplete()
    {
        _timesCompleted++;
        Console.WriteLine($"Goal '{_name}' has been completed {_timesCompleted} times.");
    }
}
