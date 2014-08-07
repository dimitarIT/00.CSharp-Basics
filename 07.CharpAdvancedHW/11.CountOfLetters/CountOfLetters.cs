//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. Use the input and output format from the examples below.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfLetters
{
    static void Main()
    {
        string lettersList = Console.ReadLine();
        string[] splitLaters = lettersList.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<char> latters = new List<char>();

        for (int i = 0; i < splitLaters.Length; i++)
        {
            latters.Add(Convert.ToChar(splitLaters[i]));
        }

        latters.Sort();

        int counter = 1;
        for (int i = 1; i < latters.Count; i++)
        {
            if (latters[i] == latters[i - 1] )
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", latters[i -1], counter);
                counter = 1;
            }

            if (i == latters.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", latters[i - 1], counter);   
            }
        }
    }
}