using System;

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter two trapezoid's sides a and b and height h.");
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h= ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Trapezoid's area is {0}", ((a+b)/2)*h);

    }
}
