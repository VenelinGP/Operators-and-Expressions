using System;

/* Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
 * The bits are counted from right to left, starting from bit #0.
 * The result of the expression should be either 1 or 0.
 */

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Enter one integer number: ");
        string number = Console.ReadLine();
        int intNumber = int.Parse(number);
        intNumber = intNumber / 8;
        int bit = intNumber % 2;
        Console.WriteLine("The bit #3 is {0}",bit);
    }
}
