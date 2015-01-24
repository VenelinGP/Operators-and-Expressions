using System;

//Write an expression that checks if given integer is odd or even.

class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter one integer number: ");
            string number = Console.ReadLine();
            int intNumber = int.Parse(number);
            bool isOdd = (intNumber % 2) != 0;
            Console.WriteLine("The {0} is Odd ? - {1}", intNumber, isOdd);
        }
    }
