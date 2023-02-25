using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.Write("What is your grade percentage? ");
                string grade = Console.ReadLine();
                int percentage = int.Parse(grade);

                string letter_grade = "";

                if (percentage >= 90)
                {
                    letter_grade = "A";
                }
                else if (percentage >= 80)
                {
                    letter_grade = "B";
                }
                else if (percentage >= 70)
                {
                    letter_grade = "C";
                }
                else if (percentage >= 60)
                {
                    letter_grade = "D";
                }
                else
                {
                    letter_grade = "F";
                }

                Console.WriteLine($"Your grade is: {letter_grade}");
                
                if (percentage >= 70)
                {
                    Console.WriteLine("You passed!");
                }
                else
                {
                    Console.WriteLine("Better luck next time!");
                }
    }
}