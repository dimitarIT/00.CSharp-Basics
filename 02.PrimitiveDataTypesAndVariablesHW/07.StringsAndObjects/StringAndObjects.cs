//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class StringAndObjects
{
    static void Main()
    {
        string hello, world, helloWorld;
        hello = "Hello";
        world = "World";

        object concatenation = hello + " " + world;
        Console.WriteLine(concatenation);

        helloWorld = hello + " " + world;
        Console.WriteLine(helloWorld);

    }
}