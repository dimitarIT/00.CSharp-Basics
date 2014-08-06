//Modify the previous application to print your name. Ensure you have named the application well (e.g. “PrintMyName”).

using System;

class PrintYourName
{
    static void Main()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is: {0}",name);
    }
}
