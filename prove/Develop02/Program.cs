using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        PromptGenerator _promptGenerator = new PromptGenerator();

        // Add prompts to the generator
        _promptGenerator.AddPrompt("Who was the most interesting person I interacted with today?");
        _promptGenerator.AddPrompt("What was the best part of my day?");
        _promptGenerator.AddPrompt("How did I see the hand of the Lord in my life today?");
        _promptGenerator.AddPrompt("What was the strongest emotion I felt today?");
        _promptGenerator.AddPrompt("If I had one thing I could do over today, what would it be?");

        bool _isJournalSaved = true;
        bool _quit = false;
        while (!_quit)
        {
            
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the current entries");
            Console.WriteLine("3. Load the journal entries from a file");
            Console.WriteLine("4. Save the journal enries to the file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");

            Console.Write("PLEASE ENTER AN OPTION: ");
            int _choice = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            switch (_choice)
            {
                case 1:
                    string _randomPrompt = _promptGenerator.GetRandomPrompt();
                    Console.WriteLine(_randomPrompt);
                    string _response = Console.ReadLine();
                    string _currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    JournalEntry _newEntry = new JournalEntry(_randomPrompt.ToString(), _response, _currentDate);
                    _journal.AddEntry(_newEntry);

                    Console.WriteLine("");
                    Console.WriteLine("Well Done! You now have a new entry in your Journal");
                    Console.WriteLine("Don't Forget to save it!");
                    Console.WriteLine("");
                    
                    _isJournalSaved = false;
                    break;
                case 2:
                    _journal.DisplayEntries();
                    break;
                case 3:
                    List<JournalEntry> fileEntries = _journal.LoadFromFile("MyJournal.txt");
                    if (fileEntries.Count == 0)
                    {
                        Console.WriteLine("No entries found in the file.");
                    }
                    else
                    {
                        Console.WriteLine($"Found {fileEntries.Count} entries in the file:");
                        Console.WriteLine("=====================================================");
                        foreach (JournalEntry entry in fileEntries)
                        {
                            Console.WriteLine($"- {entry.GetPrompt()}: {entry.GetEntryText()} ({entry.GetDate()})");
                        }
                        Console.WriteLine("=====================================================");
                    }
                    _isJournalSaved = true;
                    break;
                case 4:
                    _journal.SaveToFile("MyJournal.txt");
                    Console.WriteLine("Entries saved to MyJournal file!");
                    _isJournalSaved = true;
                    break;
                case 5:
                    if (!_isJournalSaved)
                    {
                        // prompt the user to save before quitting
                        Console.Write("You have unsaved changes. Do you want to save before quitting? (Y/N): ");
                        string _saveChoice = Console.ReadLine();
                        if (_saveChoice.ToLower() == "y")
                        {
                            // Saves the journal and set the flag to true
                            _journal.SaveToFile("MyJournal.txt");
                            Console.WriteLine("Entries saved to MyJournal file!");
                            _isJournalSaved = true;
                        }
                    }
                    _quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}
