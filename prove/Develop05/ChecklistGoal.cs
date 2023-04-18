public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private List<DateTime> _completionDates;

    public ChecklistGoal(string title, int pointValue, int timesToComplete) : base(title, pointValue)
    {
        _timesToComplete = timesToComplete;
        _completionDates = new List<DateTime>();
    }

    public int TimesToComplete
    {
        get { return _timesToComplete; }
    }

    public List<DateTime> CompletionDates
    {
        get { return _completionDates; }
    }

    public override void Display()
    {
        Console.WriteLine(ToString());
    }

    public override void CheckOff()
    {
        if (_completionDates.Count < _timesToComplete)
        {
            _completionDates.Add(DateTime.Now);
            TimesCompleted++;

            if (_completionDates.Count == _timesToComplete)
            {
                IsComplete = true;
                Console.WriteLine($"{Title} completed!");
            }
            else
            {
                Console.WriteLine($"{Title} checked off ({_completionDates.Count}/{_timesToComplete})");
            }
        }
        else
        {
            Console.WriteLine($"{Title} already completed {_timesToComplete} times!");
        }
    }

    public override string ToString()
    {
        string status = IsComplete ? "Complete" : $"Incomplete ({_completionDates.Count}/{_timesToComplete})";
        return $"{Title} ({status}), worth {PointValue} points";
    }
}
