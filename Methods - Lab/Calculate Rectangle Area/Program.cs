﻿using System;

namespace Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());   
            
            double area = rectangleArea(width, height);
            Console.WriteLine(area);
        }
        static double rectangleArea (double width, double height)
        {
            return width * height;  
        }
    }
}
