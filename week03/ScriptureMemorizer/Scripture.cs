using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordSplit = text.Split(' ');

        foreach (string word in wordSplit)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int index = random.Next(_words.Count);
        _words[index].Hide();
        
    }
    public string GetDisplayText()
    {
        string fullText = "";
        foreach (Word word in _words)
        {
            fullText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {fullText}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

