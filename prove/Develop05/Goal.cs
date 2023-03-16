public class Goal
{
    public string _name { get; set; }
    public string _goalDescription { get; set; }
    public int _points { get; set; }
    public int _completionCount { get; set; }
    public bool _completionMark { get; set; }
    public int _requiredCompletionCount { get; set; }
    public bool _isCompleted => _completionCount >= _requiredCompletionCount;

    public Goal(string name, string description, int points, bool completionMark = false, int requiredCompletionCount = 1)
    {
        _name = name;
        _goalDescription = description;
        _points = points;
        _completionMark = completionMark;
        _requiredCompletionCount = requiredCompletionCount;
    }

    public void IsComplete()
    {
        if (!_isCompleted)
        {
            _completionCount++;
        }
    }

    public string RecordEvent()
    {
        string eventRecord = $"[  ] Simple Goal: {_name} ({_goalDescription}) | {_points}";
        return eventRecord;
    }
}
