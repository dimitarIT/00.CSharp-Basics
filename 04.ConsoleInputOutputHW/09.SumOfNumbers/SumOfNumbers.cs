//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop.

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter how many numbers you want to sum: ");
        float numsForSum, sum;
        numsForSum = float.Parse(Console.ReadLine());
        sum = 0f;
        for (int i = 0; i < numsForSum; i++)
        {
            Console.Write("Please enter the numbers: ");
            float sumOfNums = float.Parse(Console.ReadLine());
            sum += sumOfNums;
        }
        Console.WriteLine("The sum of all the numbers you entered is {0}.", sum);
    }
}