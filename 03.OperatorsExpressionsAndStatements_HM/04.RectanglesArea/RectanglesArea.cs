//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:

//width	    height	    perimeter	area
//3         	4   	    14	    12
//2.5	        3	        11	    7.5
//5	            5	        20	    25

using System;

class RectanglesArea
{
    static void Main()
    {
        double width, height, rectaglesArea;
        Console.Write("Enter rectagle's width: ");
        width = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter rectagle's height: ");
        height = double.Parse(Console.ReadLine());
        Console.WriteLine();
        rectaglesArea = width * height;
        Console.WriteLine("Rectagle's ares is: {0}", rectaglesArea);
        Console.WriteLine("Rectagle's perimeter is: {0}", (2*width) + (2*height));
    }
}