//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators.

//  a	    b	    c	    result
//  5	    2	    2	    +
//  -2	    -2	    1	    +
//  -2	    4	    3	    -
//  0	    -2.5    4	    0
//  -1	    -0.5    -5.1	-

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("This program shows the sign (+, - or 0) of the product of three real numbers, without calculating it!");
        Console.Write("Please enter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Please enter c: ");
        float c = float.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0.0)
        {
            Console.WriteLine("Result is: 0");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("Result is: +");
        }
        else if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("Result is: +");
        }
        else if (a < 0 && b > 0 || c > 0 )
        {
            Console.WriteLine("Result is: -");
        }
        else if (a < 0 || b < 0 && c < 0)
        {
            Console.WriteLine("Result is: -");
        }
    }
}