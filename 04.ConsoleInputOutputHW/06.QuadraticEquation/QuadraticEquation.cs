//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("This program reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots)!");
        Console.WriteLine();
        Console.WriteLine(@"Please enter: ""a"", ""b"", ""c"";");

        double a, b, c, discriminant, firstX, SecondX;
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        discriminant = b * b - 4 * a * c;

        if (a == 0)
        {
            Console.WriteLine("Just one real root x1: {0}", -c/b);
        }
        else if (discriminant > 0)
        {
            firstX = (-b + Math.Sqrt(discriminant)) / 2 * a;
            SecondX = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("There are two real roots; x1 = {0}; x2 = {1}", firstX, SecondX);
        }
        else if ( discriminant == 0)
        {
            firstX = -b / (2 * a);
            Console.WriteLine("Just one real root x1: {0}", firstX);
        }
        else
        {
            Console.WriteLine("No real roots!");
        }
    }
}