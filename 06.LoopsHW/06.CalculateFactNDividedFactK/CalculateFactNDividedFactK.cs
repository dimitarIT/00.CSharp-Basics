//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

using System;
using System.Numerics;

class CalculateFactNDividedFactK
{
    static void Main()
    {
        byte n, k;
        BigInteger result = 1;

        do
        {
            Console.Write("n = ");
            n = byte.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = byte.Parse(Console.ReadLine());
        } while (n < 1 && k < 1 || n > 100 && k > 100);

        for (int i = n; i > k; i--)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}