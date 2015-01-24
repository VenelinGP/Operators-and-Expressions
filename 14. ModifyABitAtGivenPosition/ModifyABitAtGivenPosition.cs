using System;

/* We are given an integer number n, a bit value v (v=0 or 1) and a position p.
 * Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from 
 * he binary representation of n while preserving all other bits in n.
 */

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter one integer number: ");
        string stNumber = Console.ReadLine();
        int number = int.Parse(stNumber);
        Console.Write("Enter bit position: ");
        string stP = Console.ReadLine();
        byte p = byte.Parse(stP);
        Console.Write("Enter bit value (0 or 1): ");
        string stBit = Console.ReadLine();
        byte bit = byte.Parse(stBit);
        
        int mask;
        int result;
        if (bit == 1)
        {
            mask = 1 << p;
            result = number | mask;
        }
        else
        {
            mask = ~(1 << p);
            result = (number & mask);
        }
        Console.WriteLine("Binay representation             : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Mask                             : {0}", Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine("Binary representation result is  : {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("The result is: {0}", result);      
    }
}
