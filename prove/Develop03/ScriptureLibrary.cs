using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    private readonly List<Scripture> _scriptures = new List<Scripture>();
    
    // Variable to keep track of the index of the current scripture, It starts off as "-1" because there's no scripture selected yet.
    private int _currentScriptureIndex = -1;    
    // To generate a random number used to get a random scripture.
    private readonly Random _random = new Random();
    
    // Adds a scripture to the library.
    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }
    
    // Returns the current scripture.
    // Throws an exception if no scripture is currently selected.
    public Scripture GetCurrentScripture()
    {
        if (_currentScriptureIndex == -1)
        {
            throw new InvalidOperationException("No scripture is currently selected.");
        }
        
        return _scriptures[_currentScriptureIndex];
    }
    
    // Returns the total number of scriptures in the library.
    public int GetTotalScriptures()
    {
        return _scriptures.Count;
    }
    
    // Returns a random scripture from the library.
    // Throws an exception if there are no scriptures in the library.
    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            throw new InvalidOperationException("There are no scriptures in the library.");
        }
        
        // Generate a random index within the range of the number of scriptures in the library.
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
    
    // Removes a scripture from the library 
    internal void RemoveScripture(Scripture scripture)
    {
        _scriptures.Remove(scripture);
    }
}
