using System;

/* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 *  Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
 *  Prints on the console the number in reversed order: dcba (in our example 1102).
 *  Puts the last digit in the first position: dabc (in our example 1201).
 *  Exchanges the second and the third digits: acbd (in our example 2101).
 *  The number has always exactly 4 digits and cannot start with 0.
 */

class FourDigitNumber
{
    static void Main()
    {
        string stNumber;
        int number;
        int a;
        Console.WriteLine("The integer number must be 4 digits and cannot start with 0.");
        do
        {
            Console.Write("Enter 4-digit integer number: ");
            stNumber = Console.ReadLine();
            number = int.Parse(stNumber);
            number /= 1000;
            a = number % 10;
        } while (stNumber.Length != 4 || a == 0);
        number = int.Parse(stNumber);
        int d = number % 10;
        number /= 10;
        int c = number % 10;
        number /= 10;
        int b = number % 10;
        Console.WriteLine("1. {0} + {1} + {2} + {3} = {4}", a, b, c, d, a + b + c + d);
        Console.WriteLine("2. {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("3. {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("4. {0}{1}{2}{3}", a, c, b, d);
    }
}
