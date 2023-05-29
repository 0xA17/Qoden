using System;

namespace WordFrequencyChart.task2;

internal class Program
{
    public static void Main(String[] args)
    {
        String input = Console.ReadLine();
        String[] words = input.Split(' ');

        WordFrequencyAnalyzer analyzer = new WordFrequencyAnalyzer();
        analyzer.GenerateFrequencyDiagram(words);
    }
}