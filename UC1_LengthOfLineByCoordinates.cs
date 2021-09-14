using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC1_LengthOfLine
    {
        public static void LengthOfLine()
        {
            Console.WriteLine("To calculate Length of Line Enter Coordinates");
            Console.WriteLine("Enter Coordinates for first point as X & Y");
            int pointX1 = Convert.ToInt32(Console.ReadLine());
            int pointY1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Coordinates for first point as X & Y");
            int pointX2 = Convert.ToInt32(Console.ReadLine());
            int pointY2 = Convert.ToInt32(Console.ReadLine());
            double lengthOfLine = Math.Sqrt((Math.Pow((pointX2 - pointX1), 2) + Math.Pow((pointY2 - pointY1), 2)));
            Console.WriteLine("Length of Line is: " + lengthOfLine + " units.");
        }
    }
}
