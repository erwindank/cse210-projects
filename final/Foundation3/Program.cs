using System;
using System.Collections.Generic;

class Program {
    
    static void Main(string[] args) {
        var _events = GetEvents();
        foreach (var ev in _events) {
            Console.WriteLine();
            Console.WriteLine($"{String.Join(" ", ev.GetType().Name.Replace("Event", "").SplitOnCapitalLetters()).ToUpper()} EVENT");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Standard details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("Full details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("Short description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }

    static List<Event> GetEvents() {
        var _events = new List<Event>();
        _events.Add(new LectureEvent("Introduction to C#", "Learn the basics of C# programming", new DateTime(2023, 4, 15), new TimeSpan(14, 0, 0), new Address("2020 Main St", "Los Angeles", "CA", "90001"), "Mark Mitchel", 50));
        _events.Add(new ReceptionEvent("Networking Event", "Meet and greet with other professionals", new DateTime(2023, 5, 1), new TimeSpan(18, 0, 0), new Address("11546 Elm St", "Palmyra", "NY", "14522"), "rsvp@example.com"));
        _events.Add(new OutdoorGatheringEvent( "Picnic in the Park", "Enjoy a relaxing afternoon in the park", new DateTime(2023, 6, 15), new TimeSpan(12, 0, 0), new Address("779 Oak St", "Dallas", "TX", "75052"), "Sunny and warm"));
        return _events;
    }
}
