//Write an expression that checks if given integer is odd or even. Examples:
//  n	    Odd?
//  3	    true
//  2	    false
//  -2      false
//  -1      true
//  0	    false

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Your number is {0} even", number);
        }
        else
        {
            Console.WriteLine("Your number is {0} odd", number);
        }
    }
}