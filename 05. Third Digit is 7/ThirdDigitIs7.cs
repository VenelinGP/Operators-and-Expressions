using System;

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Enter one integer number: ");
            string stNumber = Console.ReadLine();
            int number = int.Parse(stNumber);
            number /= 100;
            bool isSeven = (number % 10) == 7;
            Console.WriteLine("Is the thirtd number is 7? - {0}", isSeven);
        }
    }
