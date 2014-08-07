//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumOf3Integers
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers a; b; c;");
        float a, b, c, sumOfnumbers;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        c = float.Parse(Console.ReadLine());
        sumOfnumbers = a + b + c;
        Console.WriteLine("The sum of numbers is: {0}", sumOfnumbers);
    }
}