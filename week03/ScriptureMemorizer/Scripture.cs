using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text )
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split("");

        foreach ( string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }
}