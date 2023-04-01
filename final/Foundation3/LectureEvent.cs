class LectureEvent : Event {
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address) {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetFullDetails() {
        return String.Format("{0}\nSpeaker: {1}\nCapacity: {2}", base.GetFullDetails(), _speaker, _capacity);
    }
}