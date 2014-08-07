//We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. Examples:

//n	    binary representation of n	    p	v	    binary result	        result
//5	    00000000 00000101	            2	0	    00000000 00000001	    1
//0	    00000000 00000000	            9	1	    00000010 00000000	    512
//15	00000000 00001111	            1	1	    00000000 00001111	    15


using System;

class ChangeTheBit
{
    static void Main()
    {
         Console.Write("Please enter integer number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter the bit position: ");
        int p = int.Parse(Console.ReadLine());
        
        Console.Write("Please enter the value to change (1 or O): ");
        int v = int.Parse(Console.ReadLine());

        if (v == 1)
        {
            int maskSetPto1 = v << p;
            int fisrtResult = n | maskSetPto1;
            Console.WriteLine("The result is: {0} ({1})", fisrtResult, Convert.ToString(fisrtResult, 2).PadLeft(32, '0'));
            Console.WriteLine("The readfafadfs: {0}", fisrtResult);

        }
        else
        {
            int mask1SetPto0 = ~(1 << p);
            int secondResult = n & mask1SetPto0;
            Console.WriteLine("The result is: {0} ({1})", secondResult, Convert.ToString(secondResult, 2).PadLeft(32, '0'));
        }
    }
}