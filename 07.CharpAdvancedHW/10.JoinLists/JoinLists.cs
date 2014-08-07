//Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoinLists
{
    static void Main()
    {   /*
        string firstLinesOfNums = Console.ReadLine();
        string secondLinesOfNums = Console.ReadLine();

        string[] firstNums = firstLinesOfNums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondNums = secondLinesOfNums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> mainList = new List<int>();
        List<int> auxiliaryList = new List<int>();

        for (int i = 0; i < firstNums.Length; i++)
        {
            auxiliaryList.Add(int.Parse(firstNums[i]));
        }

        for (int i = 0; i < secondNums.Length; i++)
        {
            auxiliaryList.Add(int.Parse(secondNums[i]));
        }

        auxiliaryList.Sort();

        mainList = auxiliaryList.Distinct().ToList();

        foreach (var number in mainList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
         
        */

        string firstLinesOfNums = Console.ReadLine();
        string secondLinesOfNums = Console.ReadLine();
        string mainstring = firstLinesOfNums + " " + secondLinesOfNums;

        string[] nums = mainstring.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> mainList = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            mainList.Add(int.Parse(nums[i]));
        }

        mainList.Sort();

        mainList = mainList.Distinct().ToList();

        foreach (int number in mainList)
        {
            Console.Write(number+ " ");
        }

        Console.WriteLine();
    }
}
