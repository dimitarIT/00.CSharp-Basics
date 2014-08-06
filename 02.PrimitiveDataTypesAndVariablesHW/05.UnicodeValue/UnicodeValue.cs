//Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.

using System;

class UnicodeValue
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The unicode of {1} is {0}", (char)number, number);
    }
}
