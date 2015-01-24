using System;

// Write an expression that extracts from given integer n the value of given bit at index p.


class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter one integer number: ");
        string stNumber = Console.ReadLine();
        int number = int.Parse(stNumber);
        Console.Write("Enter bit position: ");
        string stP = Console.ReadLine();
        int p = int.Parse(stP);
        byte bitAtPositionP = (byte)((number >> p) & 1);
        Console.WriteLine("The bit #{0} is {1}", p, bitAtPositionP);

    }
}
