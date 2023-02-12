using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture _scripture = new Scripture();

        while (showMenu);
    }

    private static bool MainMenu(Scripture _scripture)
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Save Scripture");
        Console.WriteLine("2. Discplay Scrpiture");
        Console.WriteLine("3. Quit");
        Console.Write("\r\nWhat would you ike to do?");
        string currentOption = Console.ReadLine();

        switch (currentOption)
        {
            case "1":
                _scripture.SaveScripture();
                return true;
            case "2":
                _scripture.LoadScriptureToMemorize();
                return true;
            case "3":

                return false;
            default:
                return true;            
        }
    }
    
    public void SaveScripture()
    {
        Console.WriteLine("Please write the scripture that your want to memorize");
        Console.Write("Book: ");
        string book = Console.ReadLine();
        Console.Write("Chapter: ");
        string chapter = Console.ReadLine();
        Console.Write("Verse: ");
        string verse = Console.ReadLine();
    }
}


// Please selet one of the following options 