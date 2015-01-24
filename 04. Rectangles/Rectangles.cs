using System;

// Write an expression that calculates rectangle’s perimeter and area by given width and height.

    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter width of rectangle: ");
            string stWidth = Console.ReadLine();
            double rectangleWidth = double.Parse(stWidth);
            Console.Write("Enter height of rectangle: ");
            string stHeight = Console.ReadLine();
            double rectangleHeight = double.Parse(stHeight);
            Console.WriteLine("Rectangle's perimeter is {0} and area is {1}", 2 * (rectangleHeight + rectangleWidth), rectangleWidth * rectangleHeight);
        }
    }
