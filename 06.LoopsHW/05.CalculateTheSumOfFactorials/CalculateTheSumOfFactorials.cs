//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class CalculateTheSumOfFactorials
{
    static void Main()
    {

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        decimal multiX = 1;
        decimal factN = 1;
        decimal result = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            multiX *= x;
            result += (factN / multiX);
        }

        Console.WriteLine("{0:F5}", result );
    }
}