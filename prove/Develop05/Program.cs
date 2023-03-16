using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>(); // initialize _goals with an empty list
        int _score = 0;
        string _menuSelection = "";

        while(_menuSelection != "5") // initialize _menuSelection as an empty string
        {
            string _goalName = "";
            string _goalDescription = "";
            int _goalPoints = 0;
            int _goalTimes = 0;
            int _goalBonus = 0;

            Console.WriteLine($"You have {_score} points. \n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            _menuSelection = Console.ReadLine();

            switch (_menuSelection)
            {
                case "1":
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("What type of goal would you like to create:");
                    string _goalTypeChoice = Console.ReadLine();
                    switch (_goalTypeChoice)
                    {
                        case "1":
                            Console.Write("What is the name of your goal?: ");
                            _goalName = Console.ReadLine();
                            Console.Write("What is a short description of your goal?: ");
                            _goalDescription = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal?");
                            _goalPoints = int.Parse(Console.ReadLine());
                            Goal simpleGoal = new Goal(_goalName, _goalDescription, _goalPoints);
                            _goals.Add(simpleGoal);
                            Console.WriteLine(_goals);
                            break;

                        case "2":
                            Console.WriteLine("What is the name of your goal?: ");
                            _goalName = Console.ReadLine();
                            Console.WriteLine("What is a short description of your goal?: ");
                            _goalDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal?");
                            _goalPoints = int.Parse(Console.ReadLine());
                            EternalGoal eternalGoal = new EternalGoal(_goalName, _goalDescription, _goalPoints);
                            _goals.Add(eternalGoal);
                            break;

                        case "3":
                            Console.WriteLine("What is the name of your goal?: ");
                            _goalName = Console.ReadLine();
                            Console.WriteLine("What is a short description of your goal?: ");
                            _goalDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal?");
                            _goalPoints = int.Parse(Console.ReadLine());;
                            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                            _goalTimes = int.Parse(Console.ReadLine());;
                            Console.WriteLine("What is the bonus for accomplishing it that many times?: ");
                            _goalBonus = int.Parse(Console.ReadLine());;
                            ChecklistGoal checklistGoal = new ChecklistGoal(_goalName, _goalDescription, _goalPoints, _goalTimes, _goalBonus);
                            _goals.Add(checklistGoal);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                    break;
                case "2":

                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":

                    return;

                case "6":

                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
