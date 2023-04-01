using System.Text.RegularExpressions;

class Event {
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address) {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string GetStandardDetails() {
        return String.Format("Title: {0}\nDescription: {1}\nDate: {2}\nTime: {3}\nAddress: {4}", _title, _description, _date.ToShortDateString(), _time.ToString(), _address.ToString());
    }

    public virtual string GetFullDetails() {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription() {
        return String.Format("{0} - {1} - {2}", GetType().Name, _title, _date.ToShortDateString());
    }
    
}

public static class StringExtensions
{
    public static string[] SplitOnCapitalLetters(this string str)
    {
        return Regex.Split(str, @"(?<!^)(?=[A-Z])");
    }
}
