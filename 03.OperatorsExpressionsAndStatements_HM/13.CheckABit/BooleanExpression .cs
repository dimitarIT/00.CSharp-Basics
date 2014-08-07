//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. Examples:

//n	    binary representation of n	    p	    bit @ p == 1
//5	    00000000 00000101	            2	    true
//0	    00000000 00000000	            9	    false
//15	00000000 00001111	            1	    true
//5343	00010100 11011111	            7	    true
//62241	11110011 00100001	            11	    false

using System;

class BooleanExpression 
{
    static void Main()
    {
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter the bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        int mask = 1 << bitPosition;
        int addMask = number & mask;

        if (addMask != 0)
        {
            Console.WriteLine("The bit in position {0} is 1", bitPosition);
        }
        else
        {
            Console.WriteLine("The bit in position {0} is 0", bitPosition);
        }

        Console.Write("Or: ");
        Console.WriteLine((addMask) != 0 ? true : false);
    }
}