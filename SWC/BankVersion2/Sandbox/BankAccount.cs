using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("The amount you deposit has to be above 0kr");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance = balance - amount;
                }
                else
                {
                    Console.WriteLine("You cannot withdraw {0}kr because your balance is {1}kr", amount, balance);
                }
            }
            else
            {
                Console.WriteLine("The amount you withdraw has to be above 0kr");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
