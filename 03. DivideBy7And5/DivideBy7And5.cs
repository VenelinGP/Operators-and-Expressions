using System;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter one integer number: ");
        string number = Console.ReadLine();
        int intNumber = int.Parse(number);
        bool isDivideBy7And5 = (intNumber % (7 * 5)) == 0;
        if (intNumber == 0) 
        {
            isDivideBy7And5 = false;
        }
        Console.WriteLine("Are {0} divide by 7 and 5 ? - {1}", intNumber, isDivideBy7And5);
    }
}
