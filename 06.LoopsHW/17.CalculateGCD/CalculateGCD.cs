//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet). 

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int c = 0;

        while (b != 0)
        {
            c = a % b;
            a = b;
            b = c;
        }

        Console.WriteLine("GCD(a, b) is: {0}", a);
    }
}
