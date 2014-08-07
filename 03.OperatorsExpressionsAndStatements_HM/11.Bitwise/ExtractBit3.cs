//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. Examples:
//n	        binary representation	    bit #3
//5	        00000000 00000101	        0
//0	        00000000 00000000	        0
//15	    00000000 00001111	        1
//5343	    00010100 11011111	        1
//62241	    11110011 00100001	        0

using System;

class ExtractBit3
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