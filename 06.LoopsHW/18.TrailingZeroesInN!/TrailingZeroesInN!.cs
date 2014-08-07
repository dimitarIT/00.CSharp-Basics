//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine()); //The number which factorial will be checked.

        //BigInteger factN = 1;
        //int result = 0;

        //for (int i = 1; i <= n; i++)
        //{
        //    factN *= i;
        //}
        //Console.WriteLine(factN);

        //for (int i = 5; i <= factN; i *= 5)
        //{
        //    result = result + (n / i);
        //} 
        
        //Console.WriteLine(result);

        int counter = 1;
        int sumOfZeroes = 0;

        do
        {
            sumOfZeroes = sumOfZeroes + (number / (int)Math.Pow(5, counter));
            counter++;

        } while (Math.Pow(5, counter) <= number);

        Console.WriteLine("Trailing zeroes of n! = {0}", sumOfZeroes);
    }
}
