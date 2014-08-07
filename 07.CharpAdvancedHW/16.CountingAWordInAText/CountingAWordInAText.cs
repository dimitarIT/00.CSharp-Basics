//Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word. The second line of the input holds the text. The output should be a single integer number – the number of word occurrences. Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. A word is a sequence of letters separated by punctuation or start / end of text. 

using System;
using System.Collections.Generic;
using System.Linq;

class CountingAWordInAText
{
    static void Main()
    {
        string inputWord, inputText;
        inputWord = Console.ReadLine();
        inputText = Console.ReadLine();

        int result = CompareWords(inputWord, inputText);
        Console.WriteLine(result);
    }

    static int CompareWords(string inputWord, string inputText)
    {
        string[] words = inputText.Split(new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' }, StringSplitOptions.None);

        int counter = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (string.Equals(words[i], inputWord, StringComparison.OrdinalIgnoreCase))
            {
                counter++;
            }
        }
        return counter;
    }
}
