using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC2_CompareEquality
    {
        public static void CheckEquality()
        {

            Console.WriteLine("Please Enter Coordinates for First Line");
            Console.WriteLine("Please Enter Coordinates for first point as X & Y");
            int pointX1L1 = Convert.ToInt32(Console.ReadLine());
            int pointY1L1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Coordinates for second point as X & Y");
            int pointX2L1 = Convert.ToInt32(Console.ReadLine());
            int pointY2L1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Coordinates for Second Line");
            Console.WriteLine("Please Enter Coordinates for first point as X & Y");
            int pointX1L2 = Convert.ToInt32(Console.ReadLine());
            int pointY1L2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Coordinates for second point as X & Y");
            int pointX2L2 = Convert.ToInt32(Console.ReadLine());
            int pointY2L2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfL1 = Math.Sqrt((Math.Pow((pointX2L1 - pointX1L1), 2) + Math.Pow((pointY2L1 - pointY1L1), 2)));
            Console.WriteLine("Length of Line1 as per provided points is: " + lengthOfL1 + " units.");
            string lengthOfLineOne = Convert.ToString(lengthOfL1);

            double lengthOfL2 = Math.Sqrt((Math.Pow((pointX2L2 - pointX1L2), 2) + Math.Pow((pointY2L2 - pointY1L2), 2)));
            Console.WriteLine("Length of Line2 as per provided points is: " + lengthOfL2 + " units.");
            string lengthOfLineTwo = Convert.ToString(lengthOfL2); 

            
            if (lengthOfLineOne.Equals(lengthOfLineTwo))
                Console.WriteLine("Both lines are equal in length.");
            else
                Console.WriteLine("lines are not equal in length.");
        }
    }
}
