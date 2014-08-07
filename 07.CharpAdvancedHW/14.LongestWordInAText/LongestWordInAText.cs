//Write a program to find the longest word in a text. 

using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string[] words = inputText.Split(new char[] { ' ', ',', ':', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int longesWord = 0;

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > words[longesWord].Length)
            {
                longesWord = i;
            }
        }

        Console.WriteLine(words[longesWord]);
    }
}
