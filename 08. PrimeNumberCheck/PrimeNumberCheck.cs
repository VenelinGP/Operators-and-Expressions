using System;

// Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).

class PrimeNumberCheck
{
    static void Main()
    {
        string stNumber;
        int number;
        bool isPrime;
        do
        {
            Console.Write("Enter an integer number (0 - 100): ");
            stNumber = Console.ReadLine();
            number = int.Parse(stNumber);
        } while (number > 100);
        if ( number <= 1 )
        {
            isPrime = false;
            Console.WriteLine("Prime? - {0}", isPrime);
        }
        else
        {
            for (int a = 2; a <= number / 2; a++)
            {
                if (number % a == 0)
                {
                    isPrime = false;
                    Console.WriteLine("Prime? - {0}", isPrime);
                    return;
                }

            }
            isPrime = true;
            Console.WriteLine("Prime? - {0}", isPrime);
        }


    }
}
