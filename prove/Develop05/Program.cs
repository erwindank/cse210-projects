using System;
using System.Collections.Generic;
using System.IO;

namespace GoalTrackingApp
{
    class Program
    {
        static void Main(string[] args, Goal newGoal)
        {
            Console.WriteLine("Welcome to the Goal Tracking App!");

            // Get the user's name
            Console.Write("Please enter your username: ");
            string userName = Console.ReadLine();

            // Set up the file path for the user's goals
            string filePath = $"{userName}.txt";

            // Create an empty list to hold the user's goals
            List<Goal> goals = new List<Goal>();

            // Check if the file exists for this user, and if so, load their goals from it
            if (File.Exists(filePath))
            {
                goals = LoadGoals(filePath);
            }
            else
            {
                Console.WriteLine($"No goals found for user {userName}. Creating new file at {filePath}.");
            }

            // Display the menu options to the user
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. View all goals");
                Console.WriteLine("3. Delete a goal");
                Console.WriteLine("4. Save and quit");

                // Get the user's choice
                Console.Write("> ");
                string choice = Console.ReadLine();

                // Respond to the user's choice
                switch (choice)
                {
                    case "1":
                        goals.Add(newGoal);
                        Console.WriteLine($"Goal '{newGoal.Title}' created successfully.");
                        break;
                    case "2":
                        ViewAllGoals(goals);
                        break;
                    case "3":
                        DeleteGoal(goals);
                        break;
                    case "4":
                        SaveGoals(filePath, goals);
                        Console.WriteLine($"Goals saved to file at {filePath}. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void SaveGoals(string filePath, List<Goal> goals)
        {
            throw new NotImplementedException();
        }

        private static void DeleteGoal(List<Goal> goals)
        {
            throw new NotImplementedException();
        }

        private static void ViewAllGoals(List<Goal> goals)
        {
            throw new NotImplementedException();
        }

        private static List<Goal> LoadGoals(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}