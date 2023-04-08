using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfulness App!");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("||| Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select an option from the menu: ");
            Console.WriteLine();
            string _input = Console.ReadLine();
            if (int.TryParse(_input, out int _selection))
            {
                switch (_selection)
                {
                    case 1:
                        BreathingActivity _breathing = new BreathingActivity();
                        _breathing.SetDuration();
                        _breathing.DoActivity();
                        break;                    
                    case 2:
                        ReflectingActivity _reflecting = new ReflectingActivity();
                        _reflecting.SetDuration();
                        _reflecting.DoActivity();
                        break;                    
                    case 3:
                        ListingActivity _listing = new ListingActivity();
                        _listing.SetDuration();
                        _listing.DoActivity();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the Mindfulness App!");
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }
    }
}
