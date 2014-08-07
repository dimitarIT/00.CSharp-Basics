//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveNames
{
    static void Main()
    {
        Console.Write("Enter first list of names separated by space: ");
        string firstListOfNames = Console.ReadLine();
        Console.WriteLine();

        char[] separator = new char[] {' '};
        string[] firstNames = firstListOfNames.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("Enter second list of names separated by space: ");
        string secondListiOfNames = Console.ReadLine();
        Console.WriteLine();

        string[] secondNames = secondListiOfNames.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        List<string> firstSeparatedNames = new List<string>(firstNames);
        List<string> secondSeparatedNames = new List<string>(secondNames);

        //for (int i = 0; i < secondSeparatedNames.Count; i++)
        //{
        //    for (int j = 0; j < firstSeparatedNames.Count; j++)
        //    {
        //        if (secondSeparatedNames[i] == firstSeparatedNames[j])
        //        {
        //            firstSeparatedNames.RemoveAt(j);
        //            if (j == firstSeparatedNames.Count)
        //            {
        //                break;
        //            }

        //            if (secondSeparatedNames[i] == firstSeparatedNames[j])
        //            {
        //                firstSeparatedNames.RemoveAt(j);
        //                j--;
        //                continue;
        //            }
        //        }
        //    }
        //}

        for (int i = 0; i < secondSeparatedNames.Count; i++)
        {
            for (int j = 0; j < firstSeparatedNames.Count; j++)
            {
                if (firstSeparatedNames.Contains(secondSeparatedNames[i]))
                {
                    firstSeparatedNames.Remove(secondSeparatedNames[i]);
                }
            }
        }

        foreach (var item in firstSeparatedNames)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n");
    }
}