using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MysticNumbers
    {
        public int ThreeNumbers(int a, int b, int c)
        {

            int firstNum = this.TwoNumbers(a, b);
            int secondNum = this.TwoNumbers(a, c);

            int result = firstNum;

            if (firstNum < secondNum)
            {
                result = secondNum;
            }
            
            return result;
        }

        public int TwoNumbers(int a, int b)
        {
            int result = a;

            if (a < b)
            {
                result = b;
            }
            
            return result;
        }

        public int FourNumbers(int a, int b, int c, int d)
        {
            int numOne = this.TwoNumbers(a, b);
            int numTwo = this.TwoNumbers(c, d);

            int result = numOne;

            if (numOne < numTwo)
            {
                result = numTwo;
            }

            return result;
        }
    }
}
