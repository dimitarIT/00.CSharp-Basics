//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime

using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        bool prime = IsPrime(n);
        Console.WriteLine(prime);
    }

    public static bool IsPrime(BigInteger n)
    {
        if (n == 0 || n == 1)
        {
            Console.WriteLine("The number: " + n + " is not prime number");
            return false;
        }
        else
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("The number: " + n + " is not prime number");
                    return false;
                }
            }
            Console.WriteLine("The number: " + n + " is a prime number");
            return true; 
        }
 
    }   
}