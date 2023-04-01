class ReceptionEvent : Event {
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address) {
        this._rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails() {
        return String.Format("{0}\nRSVP Email: {1}", base.GetFullDetails(), _rsvpEmail);
    }
}