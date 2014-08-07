//Write a program that calculates the perimeter and the area of given polygon (not necessarily convex) consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal digits after the decimal point. Use the input and output format from the examples. To hold the points, define a class Point(x, y). To hold the polygon use a Polygon class which holds a list of points. Find in Internet how to calculate the polygon perimeter and how to calculate the area of a polygon.
 

using System;
using System.Collections.Generic;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class PerimeterAndAreaOfPolygon
{
    static double CalculateDistance(int x1, int y1, int x2, int y2)
    {
        int distanceX = x2 - x1;
        int distanceY = y2 - y1;

        double distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
        return distance;
    }

    static double PolygonPerimeter(Point[] perimeter)
    {
        double peri = 0;
        for (int i = 0; i < perimeter.Length - 1; i++)
        {
            peri += CalculateDistance(perimeter[i].X, perimeter[i].Y,
                                      perimeter[i + 1].X, perimeter[i + 1].Y);
        }
        return peri;
    }

    static double PolygonArea(int[,] matrix, int rows)
    {
        double matrixResult;
        double leftSideSum = 0;
        double rightSideSum = 0;

        for (int i = 0; i < rows - 1; i++)
        {
            leftSideSum += (matrix[i, 0] * matrix[i + 1, 1]);
            rightSideSum += (matrix[i, 1] * matrix[i + 1, 0]);
        }

        matrixResult = Math.Abs((leftSideSum - rightSideSum) / 2);

        return matrixResult;
    }
    static void Main()
    {
        int pointsNumber = int.Parse(Console.ReadLine());
        int[,] matrix = new int[pointsNumber, 2];

        Point[] perimeter = new Point[pointsNumber];

        for (int i = 0; i < pointsNumber; i++)
        {
            string pointCoordinates = Console.ReadLine();
            string[] coordinate = pointCoordinates.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            perimeter[i] = new Point() { X = int.Parse(coordinate[0]), Y = int.Parse(coordinate[1]) };
            matrix[i, 0] = int.Parse(coordinate[0]);
            matrix[i, 1] = int.Parse(coordinate[1]);
        }

        Console.WriteLine("The Perimeter of the polygon is {0:F2}", PolygonPerimeter(perimeter));
        Console.WriteLine("The Area of the polygon is {0:F2}", PolygonArea(matrix, pointsNumber));

    }
}

/*
using System;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class DefiningSimpleClasses
{
    static void Main()
    {
        Point point = new Point() { X = 3, Y = 4 };
        Console.WriteLine("Point({0}, {1})", point.X, point.Y);
        Console.WriteLine(point); // This does not work as expected!

        Console.WriteLine("Distance = " + CalcDictance(-2, 1, 1, 3));

        Point[] line = new Point[]
        {
            new Point() { X = -2, Y = 1 },
            new Point() { X = 1, Y = 3 },
            new Point() { X = 4, Y = 2 },
            new Point() { X = 3, Y = -2 },
        };

        for (int i = 0; i < line.Length; i++)
        {
            Console.WriteLine("Point(" + line[i].X + ", " + line[i].Y + ")");
        }

        Console.WriteLine("Line length = " + CalcLineLength(line));
    }

    static double CalcLineLength(Point[] line)
    {
        double length = 0;
        for (int i = 0; i < line.Length - 1; i++)
        {
            length += CalcDictance(line[i].X, line[i].Y, line[i + 1].X, line[i + 1].Y);
        }
        return length;
    }

    static double CalcDictance(int x1, int y1, int x2, int y2)
    {
        int dx = x2 - x1;
        int dy = y2 - y1;
        double distance = Math.Sqrt(dx * dx + dy * dy);
        return distance;
    }
}
*/