//Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them.

using System;

class LongestAreaInArray
{
    static void Main()
    {
        int numberOfStrings = int.Parse(Console.ReadLine());
        string[] strings = new string[numberOfStrings];

        for (int i = 0; i < numberOfStrings; i++)
        {
            strings[i] = Console.ReadLine();
        }

        int repeat = int.MinValue;
        string checkedStr = strings[0];
        int counter = 0;
        string curentStr = strings[0];

        for (int i = 0; i < strings.Length; i++)
        {
            if (curentStr == strings[i])
            {
                counter++;
            }

            else
            {
                curentStr = strings[i];
                counter = 1;
            }

            if (counter > repeat)
            {
                repeat = counter;
                checkedStr = curentStr;
            }
            
        }
        Result(repeat, checkedStr);
    }

    static void Result(int repeat, string checkedStr)
    {
        Console.WriteLine(repeat);
        for (int i = 0; i < repeat; i++)
        {
            Console.WriteLine(checkedStr);
        }

    }
}
