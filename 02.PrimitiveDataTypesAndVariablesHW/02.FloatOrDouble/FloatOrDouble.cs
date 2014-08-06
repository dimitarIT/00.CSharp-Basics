//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        float digits7 = 12.345f;
        double digits15 = 34.567839023;
        float digits = 3456.091f;
        double digits16 = 8923.1234857;

        Console.WriteLine("{0} - This number is float!", digits7);
        Console.WriteLine("{0} - This number is double!", digits15);
        Console.WriteLine("{0} - This number is float!", digits);
        Console.WriteLine("{0} - This number is double!", digits16);
    }
}

