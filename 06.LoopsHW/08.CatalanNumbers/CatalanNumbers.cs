//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        byte n;
        BigInteger fact2N, factNPlus1, factN, catalanN;
        do
        {
            Console.Write("n = ");
            n = byte.Parse(Console.ReadLine());
        } while (n < 1 && n > 100);

        fact2N = 1;
        factNPlus1 = 1;
        factN = 1;
        catalanN = 0;

        for (int i = 1; i <= n * 2; i++)
        {
            fact2N *= i;
        }

        for (int i = 1; i <= n + 1; i++)
        {
            factNPlus1 *= i;
        }

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
        }

        catalanN = fact2N / (factNPlus1 * factN);
        Console.WriteLine("Catalan(n) = {0}", catalanN );
    }
}