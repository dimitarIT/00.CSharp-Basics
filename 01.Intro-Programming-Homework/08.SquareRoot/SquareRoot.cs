//Create a console application that calculates and prints the square root of the number 12345. Find in Internet “how to calculate square root in C#”.

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("The square root of the number {0} is: {1}", number, Math.Sqrt(number));
    }
}