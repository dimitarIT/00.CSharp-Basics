﻿//Write an expression that calculates trapezoid's area by given sides a and b and height h. Examples:

//a	        b	        h	    area	 
//5	        7	        12	    72	
//2	        1	        33	    49.5	
//8.5	    4.3	        2.7	    17.28	
//100	    200	        300	    45000	
//0.222	    0.333	    0.555	0.1540125	

using System;

class TrapezoidsArea 
{
    static void Main()
    {
        double sideA, sideB, height, area;
        Console.WriteLine("Calculates trapezoid's area by given side A anb B and height h!");
        Console.Write("Enter side A: ");
        sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side B: ");
        sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter side h: ");
        height = double.Parse(Console.ReadLine());
        area = (sideA + sideB) / 2 * height;
        Console.WriteLine("The area of the trapezoid is {0}", area);

    }
}