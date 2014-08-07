//Write a program that reads a number n and a sequence of n integers, sorts them and prints them.

using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int countOfNums = int.Parse(Console.ReadLine());
        int[] nums = new int[countOfNums];

        for (int inputNums = 0; inputNums < countOfNums; inputNums++)
        {
            Console.Write("numbers [{0}] = ", inputNums);
            nums[inputNums] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums);
        Console.WriteLine("Sorted numbers: ");
        PrintNumsInSortedArray(nums);

    }

    static void PrintNumsInSortedArray(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine("numbers = {0}", nums[i]);
        }

    }

}