using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating the scripture library with the ScriptureLibrary class and adding some scriptures 
        var _library = new ScriptureLibrary();
        _library.AddScripture(new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        _library.AddScripture(new Scripture("Philippians 4:6-7", "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God. And the peace of God, which transcends all understanding, will guard your hearts and your minds in Christ Jesus."));
        _library.AddScripture(new Scripture("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy."));
        _library.AddScripture(new Scripture("Alma 7:11-13", "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities. Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me."));
        _library.AddScripture(new Scripture("Psalm 23:1-3", "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul."));
        _library.AddScripture(new Scripture("Isaiah 41:10", "So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand."));
        _library.AddScripture(new Scripture("Doctrine and Covenants 88:118", "And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith."));
        _library.AddScripture(new Scripture("Doctrine and Covenants 82:10", "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."));

        
        // Getting a random scripture from the library
        var _currentScripture = _library.GetRandomScripture();

        // Prompt the user to press enter to start
        Console.WriteLine("Press enter to begin.");
        Console.ReadLine();

        // Loop until all words are hidden in the scripture
        while (true)
        {
            Console.Clear();

            // Display the current randomly selected scripture
            Console.WriteLine(_currentScripture.GetReference());
            Console.WriteLine(_currentScripture.GetText(true));

            // Prompt the user to press enter to hide more words or to write quit to stop the program
            Console.WriteLine("Press enter to continue, or type 'quit' to exit.");
            var _input = Console.ReadLine().ToLower();
            if (_input == "quit")
            {
                break;
            }

            // Hide a random word in the scripture
            if (!_currentScripture.HideRandomWord())
            {
                // If all words are hidden, displays a congratulations message and reset the scripture
                Console.Clear();
                Console.WriteLine("Congratulations! You have Memorized this scripture.");
                Console.WriteLine(_currentScripture.GetReference());
                Console.WriteLine(_currentScripture.GetText(false));
                Console.WriteLine();

                // Removes the current scripture from the library and get a new random scripture
                _library.RemoveScripture(_currentScripture);
                if (_library.GetTotalScriptures() == 0)
                {
                    // If there are no more scriptures in the library, exit the loop
                    Console.WriteLine("You have Memorized all the scriptures!");
                    break;
                }
                else
                {
                    _currentScripture = _library.GetRandomScripture();
                }
            }
        }
    }
}
