using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void DoActivity()
    {
        base.DoActivity();
        // Alternate Inhaling and Exhaling for the specified duration
        for (int i = 0; i < base._duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);
        }
        ClosingMessage();
    }
}
