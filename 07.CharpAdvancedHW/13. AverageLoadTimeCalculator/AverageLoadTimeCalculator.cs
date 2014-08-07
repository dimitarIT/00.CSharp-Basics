//We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double floating-point precision.

using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, double> info = new Dictionary<string, double> { };

        while (input != string.Empty)
        {
            string[] splitInput = input.Split(' ');
            string link = splitInput[2];
            double time = double.Parse(splitInput[3]);

            if (!info.Keys.Contains(link))
            {
                info[link] = time;
            }
            else
            {
                info[link] = (info[link] + time) / 2;
            }
            input = Console.ReadLine();
        }

        foreach (string link in info.Keys)
        {
            Console.WriteLine(link + " --> " + info[link]);
        }
    }
}
