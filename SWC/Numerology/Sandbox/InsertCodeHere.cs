using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            MysticNumbers myNumbers = new MysticNumbers();

            int myNum = myNumbers.ThreeNumbers(11, 10, 8);
            Console.WriteLine(myNum);

            int myTwoNum = myNumbers.TwoNumbers(5, 10);
            Console.WriteLine(myTwoNum);

            int myFourNum = myNumbers.FourNumbers(1, 11, 8, 10);
            Console.WriteLine(myFourNum);
            // The LAST line of code should be ABOVE this line
        }
    }
}
