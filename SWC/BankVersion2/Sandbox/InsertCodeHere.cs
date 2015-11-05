using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount();

            myAccount.Deposit(-100);
            myAccount.Withdraw(-100);
            myAccount.Deposit(100);
            myAccount.Withdraw(150);
            myAccount.GetBalance();
            Console.WriteLine("Balance is now : {0}", myAccount.GetBalance());


            // The LAST line of code should be ABOVE this line
        }
    }
}
