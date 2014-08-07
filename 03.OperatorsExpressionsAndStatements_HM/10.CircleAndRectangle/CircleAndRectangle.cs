//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
//x	        y	        inside K & outside of R
//1	        2	        yes
//2.5	    2	        no
//0	        1	        no
//2.5	    1	        no
//2	        0	        no
//4	        0	        no
//2.5	    1.5	        yes
//1	        2.5	        yes
//-100	    -100	    no

using System;

class CircleAndRectangle
{
    static void Main()
    {
        float top, left, width, height, radius;
        top = 1f;
        left = -1f;
        width = 6f;
        height = 2f;
        radius = 1.5f;

        Console.Write("Please enter \"x\": ");
        float pointX = float.Parse(Console.ReadLine());

        Console.Write("Please enter \"y\": ");
        float pointY = float.Parse(Console.ReadLine());

        bool resultCircle = (Math.Sqrt(1 - pointX) + (1 + pointY)) > Math.Sqrt(radius);

        bool resultRectangle = (top < pointX && pointX < width) && (left < pointY && pointY < height);

        if (resultCircle == true)
        {
            Console.Write("The point is within the circle! ");
        }
        else
        {
            Console.Write("The point (x, y) is not within the circle. ");
        }
        if (resultRectangle == true)
        {
            Console.WriteLine("And is inside the rectangle!");
        }
        else
        {
            Console.WriteLine("And is outside the rectangle!");
        }
        Console.WriteLine();
    }
}