//Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:

//n	        Third digit 7?
//5	        false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        long number = long.Parse(Console.ReadLine());
        long divider = number / 100;
        bool thirdDigit = divider % 10 == 7;
        Console.WriteLine("The third digit (right to the left) is it 7? \r\n{0}", thirdDigit);
    }
}