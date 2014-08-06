//Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble = null;

        Console.WriteLine(nullableInt + "    " + nullableDouble);

        nullableInt = nullableInt + 2;
        nullableDouble = nullableDouble + 10.25;

        Console.WriteLine(nullableInt + "    " + nullableDouble);

        nullableInt = 2;
        nullableDouble = 10.25;

        Console.WriteLine(nullableInt + "    " + nullableDouble);

        nullableInt = nullableInt + null;
        nullableDouble = nullableDouble + null;

        Console.WriteLine(nullableInt + "    " + nullableDouble);
    }
}
