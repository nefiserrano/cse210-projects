using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> notHiddenWords = _words.Where(word => !word.IsHidden()).ToList();
        for (int i = 0; i < numberToHide; i++)
        {
            int j = random.Next(notHiddenWords.Count);
            notHiddenWords[j].Hide();
            notHiddenWords.RemoveAt(j);
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText() + " ";
        reference += string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return reference;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}