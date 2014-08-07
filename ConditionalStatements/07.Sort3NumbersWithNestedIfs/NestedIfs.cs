//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

using System;

class NestedIfs
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        float c = float.Parse(Console.ReadLine());
        if (a == b && a == c)
        {
            Console.WriteLine("The result is: {0}, {1}, {2}", a, b, c);
        }
        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine("The result is: {0}, {1}, {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("The result is: {0}, {1}, {2}", a, c, b);
            }
        }

        if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine("The result is: {0}, {1}, {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("The result is: {0}, {1}, {2}", b, c, a);
            }
        }

        if (c > a && c > b)
        {
            if (a > b)
            {
                Console.WriteLine("The result is: {0}, {1}, {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("The result is: {0}, {1}, {2}", c, b, a);
            }
        }
    }
}