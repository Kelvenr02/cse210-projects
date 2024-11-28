using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _totalWords;
    private int _totalWordsHidden;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _totalWordsHidden = 0;
        foreach (string words in text.Split())
        {
            _words.Add(new Word(words));
            _totalWords = _words.Count();
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList(); // Filtrar palavras que ainda estão visíveis. word => !word.IsHidden() é uma função lambda. como usado no Python
        numberToHide = Math.Min(numberToHide, visibleWords.Count);// Ajustar o número de palavras a esconder, se necessário. Ex.: Caso tenha menos palavras visíveis do que solicitado
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex); // Remover a palavra oculta da lista de visíveis
        }
        _totalWordsHidden += numberToHide;
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplayText()} ";
        }
        return displayText.Trim();
    }
    public bool IsCompletelyHidden()
    {
        return _totalWordsHidden >= _totalWords;
    }
}