using System;

public class Scripture
{

    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (var wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }
    public Reference GetReference()
    {
        return _reference;
    }

    public void SetReference(Reference reference)
    {
        _reference = reference;
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void SetWords(List<Word> words)
    {
        _words = words;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}