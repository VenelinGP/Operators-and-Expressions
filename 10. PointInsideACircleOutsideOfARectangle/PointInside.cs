using System;

/* Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
 * and out of the rectangle R(top=1, left=-1, width=6, height=2)
*/

    class PointInside
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers coordinates of a point ");
            Console.Write("X= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y= ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine();
            bool isInCircle = (((x-1) * (x-1) + (y-1) * (y-1)) <= 1.5 * 1.5);
            if (isInCircle)
            {
                if (y > 1)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
