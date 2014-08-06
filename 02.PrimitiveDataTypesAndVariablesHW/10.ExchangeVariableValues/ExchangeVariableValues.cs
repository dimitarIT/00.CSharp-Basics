//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a, b, c, d;
        a = 5;
        b = 10;
        c = a;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
