﻿using System;

/* The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter weight on the Earth: ");
            string weight = Console.ReadLine();
            double doublelWeight = double.Parse(weight);
            Console.WriteLine("Weight on the Moon will be {0}", doublelWeight*0.17);
        }
    }
