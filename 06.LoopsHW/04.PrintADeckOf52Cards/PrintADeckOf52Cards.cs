//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;
using System.Text;
class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode; 
        for (int n = 1; n <= 13; n++)
        {
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                switch (n)
                {
                    case 1:
                        Console.Write(2);
                        break;
                    case 2:
                        Console.Write(3);
                        break;
                    case 3:
                        Console.Write(4);
                        break;
                    case 4:
                        Console.Write(5);
                        break;
                    case 5:
                        Console.Write(6);
                        break;
                    case 6:
                        Console.Write(7);
                        break;
                    case 7:
                        Console.Write(8);
                        break;
                    case 8:
                        Console.Write(9);
                        break;
                    case 9:
                        Console.Write(10);
                        break;
                    case 10:
                        Console.Write("J");
                        break;
                    case 11:
                        Console.Write("D");
                        break;
                    case 12:
                        Console.Write("K");
                        break;
                    case 13:
                        Console.Write("A");
                        break;
                    default:
                        break;
                }

                if (i < 1)
                {
                    Console.Write((char)5);
                }

                else if (i < 2)
                {
                    Console.Write((char)4);
                }

                else if (i < 3)
                {
                    Console.Write((char)3);
                }

                else
                {
                    Console.Write((char)6);
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
        sbyte[] sings = { 5, 4, 3, 6};

        foreach (var card in cards)
        {
            foreach (var sing in sings)
            {
                Console.Write(card);
                Console.Write((char)sing);
            }

            Console.WriteLine();
        }
    }
}
