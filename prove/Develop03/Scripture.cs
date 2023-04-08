using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private readonly string _reference;
    private readonly string _text;
    private readonly List<string> _hiddenWords = new List<string>();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public string GetReference()
    {
        return _reference;
    }

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
            // Show the scripture text with hidden words removed
            string[] _words = _text.Split(' ');
            return string.Join(" ", _words.Except(_hiddenWords));
        }
    }

    public bool HideRandomWord()
    {
        // Get all words that are not already hidden
        string[] _words = _text.Split(' ');
        var availableWords = _words.Except(_hiddenWords).ToArray();
        if (availableWords.Length == 0)
        {
            // All words are already hidden, so cannot hide any more
            return false;
        }

        // Choose a random word to hide and add it to the list of hidden words
        string _word = availableWords[new Random().Next(availableWords.Length)];
        _hiddenWords.Add(_word);
        return true;
    }
}
