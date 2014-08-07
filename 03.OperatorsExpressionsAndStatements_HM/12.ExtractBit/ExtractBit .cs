//Write an expression that extracts from given integer n the value of given bit at index p. Examples:

//n	        binary representation	p	bit @ p
//5	        00000000 00000101	    2	1
//0	        00000000 00000000	    9	0
//15	    00000000 00001111	    1	1
//5343	    00010100 11011111	    7	1
//62241	    11110011 00100001	    11	0

using System;

class Program
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