//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("This program, reads the radius r of a circle and prints its perimeter and area! ");
        Console.Write("Please enter the radius r of a circle r: ");
        decimal radius = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Area: {0:F2}", (decimal)Math.PI * (radius * radius));
        Console.WriteLine("Perimeter: {0:F2}", 2 * (decimal)Math.PI * radius);
    }
}