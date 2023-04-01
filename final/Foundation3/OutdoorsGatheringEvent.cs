class OutdoorGatheringEvent : Event {
    private string _weather;

    public OutdoorGatheringEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weather) : base(title, description, date, time, address) {
        this._weather = weather;
    }

    public override string GetFullDetails() {
        return String.Format("{0}\nWeather: {1}", base.GetFullDetails(), _weather);
    }
}