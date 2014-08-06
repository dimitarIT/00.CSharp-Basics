//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariables
{
    static void Main()
    {
        byte unsignedByte = 97;
        sbyte signedByte = -115;
        short signedShort = -10000;
        ushort unsignedShort = 52130;
        int signedInteger;
        uint unsignedInteger = 4825932;
        long signedLong;
        ulong unsignedLong;

        Console.WriteLine(unsignedByte);
        Console.WriteLine(signedByte);
        Console.WriteLine(signedShort);
        Console.WriteLine(unsignedShort);
        Console.WriteLine(unsignedInteger);
    }
}

