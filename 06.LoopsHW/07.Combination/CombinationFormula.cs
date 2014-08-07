//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations). For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. 

using System;
using System.Numerics;

class CombinationFormula
{
    static void Main()
    {
        byte n, k;
        do
        {
            Console.Write("n = ");
            n = byte.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = byte.Parse(Console.ReadLine());
        } while (n < 1 && k < 1 || n > 100 && k > 100);
          
        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factNandK = 1;
        BigInteger result = 0;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            if (i <= k)
            {
                factK *= i;
            }

            if (i <= (n - k))
            {
                factNandK *= i;
            }
        }

        Console.WriteLine(result = factN / (factK * factNandK));
    }
}