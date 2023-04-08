using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts;
    private List<string> _listingResponses;

    public ListingActivity() : base("Listing Activity", "This activity will help you refelct on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _listingPrompts = new List<string> 
        { 
            "List 10 things you're grateful for.", 
            "List 5 people who have positively impacted your life and why.", 
            "List 3 accomplishments you're proud of and why.", 
            "List 5 things that make you happy and why." 
        };
        _listingResponses = new List<string>();
    }

    public string GetRandomListingPrompt()
    {
        Random rand = new Random();
        return _listingPrompts[rand.Next(_listingPrompts.Count)];
    }

    public override void DoActivity()
    {
        base.DoActivity();
        Console.Write($"--- {GetRandomListingPrompt()} ---\n");

        CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(_duration));

        int responseCount = 0;
        while (!cts.IsCancellationRequested)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _listingResponses.Add(response);
            responseCount++;
        }

        Pause(10);
        Console.WriteLine($"Great job! You listed {responseCount} responses.");
        Console.WriteLine("Your responses are: \n");
        foreach (string response in _listingResponses)
        {
            Console.WriteLine($"> {response}");
        }
    }
}
