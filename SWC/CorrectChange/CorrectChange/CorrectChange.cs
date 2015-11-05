using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectChange
{
    internal class CorrectChange
    {

        private int dueAmountInt, paidAmountInt, calcReturn, returnedAmount, calcReturnTwo, returnedAmountTwo, calcReturnList, calcReturnListTwo, returnedAmountList, returnedAmountListTwo;
        private string paidAmount, dueAmount;

        private int[] returns =
        {
            1000,
            500,
            200,
            100,
            50,
            20,
            10,
            5,
            2,
            1
        };

        private List<int> returnsList = new List<int>(); 

        public CorrectChange()
        {
            returnsList.AddRange(returns);
        }

        public void run()
        {
            Console.Write("Please enter the amount due: ");

            dueAmount = Console.ReadLine();

            try
            {
                dueAmountInt = int.Parse(dueAmount);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Please enter the amount you wish to pay: ");

            paidAmount = Console.ReadLine();

            try
            {
                paidAmountInt = int.Parse(paidAmount);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            while (paidAmountInt < dueAmountInt)
            {
                Console.Write("You have not paid enough. Please pay more than the due amount: ");

                paidAmount = Console.ReadLine();

                try
                {
                    paidAmountInt = int.Parse(paidAmount);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            Console.WriteLine(".....");
            Console.WriteLine("You have entered that {0}kr is due, and you have paid {1}kr.", dueAmountInt, paidAmountInt);
            Console.WriteLine("Please wait while the system calculates your change using an array.");
            Console.WriteLine(".....");

            calcReturn = paidAmountInt - dueAmountInt;
            calcReturnTwo = calcReturn;

            foreach (var element in returns)
            {
                while (element <= calcReturn)
                {
                    calcReturn -= element;
                    Console.WriteLine("Returned {0}kr", element);
                    returnedAmount += element;
                }
            }

            Console.WriteLine(".....");
            Console.WriteLine("Returned {0}kr, using a foreach loop.", returnedAmount);
            Console.WriteLine(".....");

            for (int i = 0; i < returns.Length; i++)
            {
                while (returns[i] <= calcReturnTwo)
                {
                    calcReturnTwo -= returns[i];
                    Console.WriteLine("Returned {0}kr", returns[i]);
                    returnedAmountTwo += returns[i];
                }
            }

            Console.WriteLine(".....");
            Console.WriteLine("Returned {0}kr, using a for loop.", returnedAmountTwo);
            Console.WriteLine(".....");


            /*
            * Now we will do the same just by using the list
            */


            Console.WriteLine("You have entered that {0}kr is due, and you have paid {1}kr.", dueAmountInt, paidAmountInt);
            Console.WriteLine("Please wait while the system calculates your change using a list.");
            Console.WriteLine(".....");

            calcReturnList = paidAmountInt - dueAmountInt;
            calcReturnListTwo = calcReturnList;

            foreach (var element in returnsList)
            {
                while (element <= calcReturnList)
                {
                    calcReturnList -= element;
                    Console.WriteLine("Returned {0}kr", element);
                    returnedAmountList += element;
                }
            }

            Console.WriteLine(".....");
            Console.WriteLine("Returned {0}kr, using a foreach loop.", returnedAmountList);
            Console.WriteLine(".....");

            for (int i = 0; i < returnsList.Count; i++)
            {
                while (returnsList[i] <= calcReturnListTwo)
                {
                    calcReturnListTwo -= returnsList[i];
                    Console.WriteLine("Returned {0}kr", returnsList[i]);
                    returnedAmountListTwo += returnsList[i];
                }
                
            }
            Console.WriteLine(".....");
            Console.WriteLine("Returned {0}kr, using a for loop.", returnedAmountListTwo);
            Console.WriteLine(".....");
        }

    }
}
