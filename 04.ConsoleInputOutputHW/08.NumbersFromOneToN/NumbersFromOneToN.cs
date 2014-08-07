//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop.

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Please enter number: ");
        double number = double.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("The numbers in the interval [1..n]: {0}", 1 + i);
        }
    }
}