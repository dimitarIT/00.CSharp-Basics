//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Text;

class FormattingNumbers
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        short a;
        float b, c;
        Console.WriteLine("Please enter three numbers!");

        Console.Write("Please enter an integer \"a\"; (0 ≤ a ≤ 500): ");
        a = short.Parse(Console.ReadLine());
        Console.Write("Please enter a floating-point \"b\": ");
        b = float.Parse(Console.ReadLine());
        Console.Write("Please enter a floating-point \"c\": ");
        c = float.Parse(Console.ReadLine());
        string d = Convert.ToString(a, 2);

        Console.WriteLine();
        Console.WriteLine("|{0, -10:X}|{1,10}|{2, 10}|{3,-10:F3}|", a, d.PadLeft(10, '0'), b, c );
    }
}