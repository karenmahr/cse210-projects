using System;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;

    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    private void Show()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            string underscore = "";

            for (int i = 0; i < _text.Length; i++)
            {
                underscore += "_";
            }
            return underscore;
        }
    }
}

