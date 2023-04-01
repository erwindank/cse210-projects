using System;

class Program {
    static void Main(string[] args) {
        Address _address1 = new Address("2020 Main St", "Los Angeles", "CA", "90001");
        Address _address2 = new Address("11546 Elm St", "Palmyra", "NY", "14522");
        Address _address3 = new Address("779 Oak St", "Dallas", "TX", "75052");

        LectureEvent _lecture = new LectureEvent("Introduction to C#", "Learn the basics of C# programming", new DateTime(2023, 4, 15), new TimeSpan(14, 0, 0), _address1, "Mark Mitchel", 50);
        ReceptionEvent _reception = new ReceptionEvent("Networking Event", "Meet and greet with other professionals", new DateTime(2023, 5, 1), new TimeSpan(18, 0, 0), _address2, "rsvp@example.com");
        OutdoorGatheringEvent _outdoorGathering = new OutdoorGatheringEvent("Picnic in the Park", "Enjoy a relaxing afternoon in the park", new DateTime(2023, 6, 15), new TimeSpan(12, 0, 0), _address3, "Sunny and warm");

        Console.WriteLine("LECTURE EVENT");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Standard details");
        Console.WriteLine(_lecture.GetStandardDetails());
        Console.WriteLine("Full details:");
        Console.WriteLine(_lecture.GetFullDetails());
        Console.WriteLine("Short description:");
        Console.WriteLine(_lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("RECEPTION EVENT");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Standard details");
        Console.WriteLine(_reception.GetStandardDetails());
        Console.WriteLine("Full details:");
        Console.WriteLine(_reception.GetFullDetails());
        Console.WriteLine("Short description:");
        Console.WriteLine(_reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("OUTDOR GATHERING EVENT");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Standard details");
        Console.WriteLine(_outdoorGathering.GetStandardDetails());
        Console.WriteLine("Full details:");
        Console.WriteLine(_outdoorGathering.GetFullDetails());
        Console.WriteLine("Short description:");
        Console.WriteLine(_outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}
