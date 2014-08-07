//Write a program that finds the biggest of five numbers by using only five if statements

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        float c = float.Parse(Console.ReadLine());
        Console.Write("Please enter number d: ");
        float d = float.Parse(Console.ReadLine());
        Console.Write("Please enter number e: ");
        float e = float.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The biggest of five number is a: {0}", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The biggest of five number is b: {0}", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The biggest of five number is c: {0}", c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The biggest of five number is d: {0}", d);
        }
        else
        {
            Console.WriteLine("The biggest of five number is e: {0}", e);
        }
    }
}