using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int amountToPay = 266;
            int paidAmount = 500;

            int changeToPayBack = paidAmount - amountToPay;


            // To keep things simple, we assume that you pay back
            // change as: 1-kr coins, 10-kr coins and 100-kr bills.

            int noOf1krCoins = 0;
            int noOf5krCoins = 0;
            int noOf10krCoins = 0;
            int noOf50krBills = 0;
            int noOf100krBills = 0;


            // YOUR JOB: Add code to calculate the correct change

            int change = paidAmount - amountToPay;

            while (change > 100)
            {
                noOf100krBills ++;
                change = change - 100;
            }

            while (change > 50)
            {
                noOf50krBills ++;
                change -= 50;
            }

            while (change > 10)
            {
                noOf10krCoins++;
                change -= 10;
            }

            while (change > 5)
            {
                noOf5krCoins++;
                change -= 5;
            }

            while (change > 0)
            {
                noOf1krCoins++;
                change -= 1;
            }

            Console.WriteLine("Your change is {0} 1-kr coins, {1} 5-kr coins, {2} 10-kr coins, {3} 50-kr bills and {4} 100-kr bills.", noOf1krCoins, noOf5krCoins, noOf10krCoins, noOf50krBills, noOf100krBills);
            Console.WriteLine("A total of {0} kr", changeToPayBack);


            // The LAST line of code should be ABOVE this line
        }
    }
}
