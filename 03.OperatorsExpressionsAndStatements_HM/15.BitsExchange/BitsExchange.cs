//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 

using System;

class BitsExchange
{
    static void Main()
    {
        long number = uint.Parse(Console.ReadLine());
        long mask = 7;
        long getFirstBits = ((mask << 3) & number) >> 3; 
        long getSecondBits = ((mask << 24) & number) >> 24;          
        number = ~(mask << 24) & number;                         
        number = ~(mask << 3) & number;                          
        number = (getFirstBits << 24) | number;      
        number = (getSecondBits << 3) | number;                    
        Console.WriteLine(number);

        // input
        uint input = uint.Parse(Console.ReadLine());

        // logic
        uint result = input;

        // generate mask
        uint mask1 = 7 << 3;
        uint mask2 = 7 << 24;

        //read bits 3, 4, 5, and 24, 25, 26
        uint bits345 = input & mask1;
        uint bits2456 = input & mask2;

        // place zeros in bits positions
        result &= ~mask2;
        // = result & ~mask2;

        // swap bits
        bits345 <<= (24 - 3);
        bits2456 = bits2456 >> (24 - 3);

        // place bits in positions
        result |= bits345;
        result |= bits2456;

        // output
        Console.WriteLine(result);


        // next problem
        //int n = int.Parse(Console.ReadLine());
        //int mask = 0;

        //for (int i = 0; i < n; i++)
        //{
        //    mask <<= 1;
        //    mask |= 1;
        //}
        //Console.WriteLine(mask);
        //Console.WriteLine(Convert.ToString(mask , 2));
    }
}