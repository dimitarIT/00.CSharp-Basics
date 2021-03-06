﻿//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:

//n	    sum of digits	    reversed	    last digit in front	    second and third digits exchanged
//2011	    4	             1102	            1201	                        2101
//3333	    12	             3333	            3333	                        3333
//9876	    30	             6789	            6987	                        9786

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter four integer numbers: ");
        int number = int.Parse(Console.ReadLine());
        int d = number % 10;
        number /= 10;
        int c = number % 10;
        number /= 10;
        int b = number % 10;
        number /= 10;
        int a = number % 10;

        Console.WriteLine("The sum of the your digits {0} + {1} + {2} + {3} is : {4}", a, b, c, d, (a + b + c + d));
        Console.WriteLine("Your number in reversed order is : {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Let's put the last digit in the first position: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Let's exchange the second and the third digits: {0}{1}{2}{3}", a, c, b, d);
    }
}