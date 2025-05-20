using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] wordSplit = text.Split(' ');
        
        foreach(string word in wordSplit)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

    }
    private void HideRandomWords(int numberToHide)
    {
       Random randomGenerator = new Random();
        int numberToHide = randomGenerator.Next(1, 3);
    }

    private string GetDisplayText()
    {
        foreach (Word Word in _words)
        {
        if (Word = Show())
        {
            return _text;
        }  
        else
        {
            return "_____";
        }
        }
    }
    private bool IsCompletelyHidden()
    {
     
    }
}