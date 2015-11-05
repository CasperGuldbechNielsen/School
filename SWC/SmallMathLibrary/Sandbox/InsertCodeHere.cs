using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Tests of the Math Library:
            MathLib mLib = new MathLib();

            Console.WriteLine("Faculty(3), expected result : 6, got {0}", mLib.Faculty(3));
            Console.WriteLine("Faculty(8), expected result : 40320, got {0}", mLib.Faculty(8));
            Console.WriteLine("Faculty(1), expected result : 1, got {0}", mLib.Faculty(1));

            Console.WriteLine("IntervalSum(3,7), expected result : 25, got {0}", mLib.IntervalSum(3, 7));
            Console.WriteLine("IntervalSum(0,100), expected result : 5050, got {0}", mLib.IntervalSum(0, 100));
            Console.WriteLine("IntervalSum(7,2), expected result : 0, got {0}", mLib.IntervalSum(7, 2));

            Console.WriteLine("HighestSquareBelowLimit(20), expected result : 16, got {0}", mLib.HighestSquareBelowLimit(20));
            Console.WriteLine("HighestSquareBelowLimit(200), expected result : 196, got {0}", mLib.HighestSquareBelowLimit(200));
            Console.WriteLine("HighestSquareBelowLimit(-20), expected result : 0, got {0}", mLib.HighestSquareBelowLimit(-20));

            Console.WriteLine("IsPrime(20), expected result : False, got {0}", mLib.IsPrime(20));
            Console.WriteLine("IsPrime(41), expected result : True, got {0}", mLib.IsPrime(41));
            Console.WriteLine("IsPrime(103), expected result : True, got {0}", mLib.IsPrime(103));
            Console.WriteLine("IsPrime(91), expected result : False, got {0}", mLib.IsPrime(91));


            // The LAST line of code should be ABOVE this line
        }
    }
}
