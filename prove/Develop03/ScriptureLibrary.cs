using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    private readonly List<Scripture> _scriptures = new List<Scripture>();
    private int _currentScriptureIndex = -1;
    private readonly Random _random = new Random();
    
    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }
    
    public Scripture GetCurrentScripture()
    {
        if (_currentScriptureIndex == -1)
        {
            throw new InvalidOperationException("No scripture is currently selected.");
        }
        
        return _scriptures[_currentScriptureIndex];
    }
    
    public int GetTotalScriptures()
    {
        return _scriptures.Count;
    }
    
    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            throw new InvalidOperationException("There are no scriptures in the library.");
        }
        
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }

    internal void RemoveScripture(Scripture scripture)
    {
        _scriptures.Remove(scripture);
    }
}
