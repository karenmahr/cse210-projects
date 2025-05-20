using System;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    private void Hide()
    {
        Console.WriteLine(_isHidden);
    }
    private void Show()
    {
        Console.WriteLine(_text);
    }
    private bool IsHidden()
    {
        return ;
    }
    private string GetDisplayText()
    {
        return _text;
    }
}