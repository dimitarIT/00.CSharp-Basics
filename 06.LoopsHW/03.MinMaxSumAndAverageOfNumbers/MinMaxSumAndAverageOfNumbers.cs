//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. 

using System;

class MinMaxSumAndAverageOfNumbers
{
    static void Main()
    {
        // input
        Console.Write("Please enter number for sequence of integer numbers: ");
        int sequence = int.Parse(Console.ReadLine());
        int minNum = int.MaxValue;
        int maxNum = int.MinValue;
        float sum = 0f;
        float average = 0f;

        // solution
        for (int i = 0; i < sequence; i++)
        {
            int number = int.Parse(Console.ReadLine());
            minNum = Math.Min(minNum, number);
            maxNum = Math.Max(maxNum, number);
            sum = sum + number;
            average = sum / 2;
        }

        // output
        Console.WriteLine("Min = {0}", minNum);
        Console.WriteLine("Max = {0}", maxNum);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Avg = {0:F2}", average);
    }
}