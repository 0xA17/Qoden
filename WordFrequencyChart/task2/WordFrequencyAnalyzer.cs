using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequencyChart.task2;

public class WordFrequencyAnalyzer
{
    public void GenerateFrequencyDiagram(String[] words)
    {
        Dictionary<String, Int32> wordCount = CountWords(words);
        List<KeyValuePair<String, Int32>> sortedWords = SortWordsByFrequency(wordCount);
        Int32 maxWordLength = GetMaxWordLength(sortedWords);

        foreach (var pair in sortedWords)
        {
            String word = pair.Key;
            Int32 count = pair.Value;
            String dots = GenerateDots(count, sortedWords[0].Value);

            String formattedWord = FormatWord(word, maxWordLength);
            Console.WriteLine($"{formattedWord} {dots}");
        }
    }

    private Dictionary<String, Int32> CountWords(String[] words)
    {
        Dictionary<String, Int32> wordCount = new Dictionary<String, Int32>();

        foreach (String word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        return wordCount;
    }

    private List<KeyValuePair<String, Int32>> SortWordsByFrequency(Dictionary<String, Int32> wordCount)
    {
        return wordCount.OrderByDescending(pair => pair.Value).ToList();
    }

    private Int32 GetMaxWordLength(List<KeyValuePair<String, Int32>> sortedWords)
    {
        return sortedWords.Max(pair => pair.Key.Length);
    }

    private String GenerateDots(Int32 count, Int32 maxCount)
    {
        const Int32 maxDotCount = 10;
        Int32 dotCount = (Int32)Math.Round((Double)count / maxCount * maxDotCount);

        return new String('.', dotCount);
    }

    private String FormatWord(String word, Int32 maxWordLength)
    {
        Int32 paddingLength = maxWordLength - word.Length;
        String padding = new String('_', paddingLength);

        return padding + word;
    }
}