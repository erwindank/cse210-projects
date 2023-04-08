using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> prompts;
    private List<string> questions;

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        prompts = new List<string> 
        { 
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless." 
        };
        questions = new List<string> 
        { 
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?", 
            "What made this time different than other times when you were not as successful?", 
            "What is your favorite thing about this experience?", 
            "What could you learn from this experience that applies to other situations?", 
            "What did you learn about yourself through this experience?", 
            "How can you keep this experience in mind in the future?" 
        };
    }

    public override void DoActivity()
    {
        base.DoActivity();
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause(3);

        for (int i = 0; i < _duration / 6; i++)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine(question);
            Pause(10);
        }
        Console.WriteLine("Reflection activity complete.");
    }
    public void PrintProperties()
    {
        Type type = this.GetType();
        Console.WriteLine($"Properties of {type.Name} class:");
        foreach (var prop in type.GetProperties())
        {
            Console.WriteLine($"Name: {prop.Name} Type: {prop.PropertyType}");
        }
    }

    public void PrintMethods()
    {
        Type type = this.GetType();
        Console.WriteLine($"Methods of {type.Name} class:");
        foreach (var method in type.GetMethods())
        {
            Console.WriteLine($"Name: {method.Name} Return Type: {method.ReturnType}");
        }
    }
}