using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class DiceCup
    {
        private Die die1;
        private Die die2;

        private int die1Roll, die2Roll;
        private int diceRoll;

        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
            die1 = new Die();
            die2 = new Die();
        }

        // You must create a method with the below header:
        // public void RollDice()

        public void RollDice()
        {
            die1.RollDie();
            die2.RollDie();
        }

        // You must create a method with the below header:
        // public int GetTotalValue()

        public int getTotalValue()
        {
            die1Roll = die1.GetValue();
            die2Roll = die2.GetValue();
            diceRoll = die1Roll + die2Roll;
            return diceRoll;
        }

        // You must create a method with the below header:
        // public bool IsTotalValueLargerThan(int value)

        public bool isTotalValueLargerThan(int value)
        {
            if (diceRoll > value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
