//Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. Use the input and output format from the examples below.

using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string listOfNames = Console.ReadLine();
        string[] splitNames = listOfNames.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> names = splitNames.ToList<string>();

        names.Sort();

        int counter = 1;

        for (int i = 1; i < names.Count; i++)
        {
            if (names[i] == names[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", names[i - 1], counter);
                counter = 1;
            }

            if (i == names.Count - 1)
            {
                 Console.WriteLine("{0} -> {1}", names[i], counter); 
            }
        }
    }
}
