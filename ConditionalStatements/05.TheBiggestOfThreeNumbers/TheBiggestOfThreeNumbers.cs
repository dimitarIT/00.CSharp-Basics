//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        float c = float.Parse(Console.ReadLine());
  
        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine("The result is: {0}, {1}, {2}", a, b, c);
            }
            else if (b < c)
            {
                Console.WriteLine("{0}{1}{2}", a, c, b);
            }
        }
    }
}