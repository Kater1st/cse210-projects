using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count && words.Any(w => !w.ToString().Equals("___")))
        {
            int index = random.Next(words.Count);
            if (!words[index].ToString().Equals("___"))
            {
                words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public void Display()
    {
        Console.WriteLine(reference);
        Console.WriteLine(string.Join(" ", words));
    }
}