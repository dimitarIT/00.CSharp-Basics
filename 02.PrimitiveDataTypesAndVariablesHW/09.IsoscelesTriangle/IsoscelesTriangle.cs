//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and the console font.

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        char copyRight = '\u00a9';
        byte br = 10;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < br; j++) Console.Write(" ");
            for (int t = 0; t <= i; t++)
            {
                Console.Write(copyRight);
            }
            for (int t = 0; t <= i - 1; t++)
            {
                Console.Write(copyRight);
            }
            br--;
            Console.WriteLine();
        }
    }
}
