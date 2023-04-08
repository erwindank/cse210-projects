using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private readonly string _reference;
    private readonly string _text;
    private readonly List<string> _hiddenWords = new List<string>();

    //Sets the reference and text of a new scripture. 
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    // Returns the reference of the scripture.
    public string GetReference()
    {
        return _reference;
    }

    // Returns the text of the scripture, with hidden words replaced by underscores.
    public string GetText(bool showHiddenWords)
    {
        if (showHiddenWords)
        {
            // Show the scripture text with all hidden words replaced by underscores
            string[] _words = _text.Split(' ');
            for (int i = 0; i < _words.Length; i++)
            {
                if (_hiddenWords.Contains(_words[i]))
                {
                    _words[i] = new string('_', _words[i].Length);
                }
            }
            return string.Join(" ", _words);
        }
        else
        {
            // Show the scripture text with hidden words.
            string[] _words = _text.Split(' ');
            return string.Join(" ", _words.Except(_hiddenWords));
        }
    }

    // Hides a random word in the scripture by adding it to the list of hidden words.
    public bool HideRandomWord()
    {
        // Split the text into individual words and get the ones that aren't already hidden.
        string[] _words = _text.Split(' ');
        var availableWords = _words.Except(_hiddenWords).ToArray();

        // Detect if there are no words left to hide.
        if (availableWords.Length == 0)
        {
            return false;
        }

        // Chooses a random word to hide and adds it to the list of hidden words
        string _word = availableWords[new Random().Next(availableWords.Length)];
        _hiddenWords.Add(_word);
        return true;
    }
}
