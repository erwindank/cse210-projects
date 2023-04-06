class JournalEntry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetEntryText()
    {
        return _response;
    }

    public string GetDate()
    {
        return _date;
    }

    public override string ToString()
    {
        return $"{_prompt}: {_response} ({_date})";
    }
}
