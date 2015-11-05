using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // Case 1
            Console.WriteLine("Start of case 1");
            for (int i = 0; i < 15; i = i + 3)
            {
                Console.WriteLine(i); // Uncomment to see result
            }
            Console.WriteLine("End of case 1");


            // Case 2
            Console.WriteLine("Start of case 2");
            for (int i = 10; i >= 3; i--)
            {
                Console.WriteLine(i); // Uncomment to see result
            }
            Console.WriteLine("End of case 2");


            // Case 3 - Change this to a for-loop!
            Console.WriteLine("Start of case 3");
            for (int i = 2; i <= 12; i++)
            {
                if ((i%2) == 1)
                {

                }
                Console.WriteLine(i);

            }
            Console.WriteLine("End of case 3");


            // Case 4 - Change this to a for-loop! 0-2-6-14-30
            Console.WriteLine("Start of case 4");
            for (int i = 0; i <= 30; i = i * 2 + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of case 4");

            // The LAST line of code should be ABOVE this line
        }
    }
}
