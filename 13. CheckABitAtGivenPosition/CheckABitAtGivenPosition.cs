using System;

/* Write a Boolean expression that returns if the bit at position p
* (counting from 0, starting from the right) in given integer number n, has value of 1.
*/
class CheckABitAtGivenPosition
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
        bool check = (bitAtPositionP == 1);
        Console.WriteLine("{0}", check);
    }
}
