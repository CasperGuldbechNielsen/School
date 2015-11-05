using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DiceGame
{
    class InsertCodeHere
    {

        private int totalValue;
        private bool isLarger;
        private int _randomNum;

        private Random generator;

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Die die = new Die();

            die.RollDie();
            int dieRoll = die.GetValue();

            Console.WriteLine(dieRoll);

            Console.WriteLine(".....................");

            DiceCup diceCup = new DiceCup();

            diceCup.RollDice();
            totalValue = diceCup.getTotalValue();

            generator = new Random();
            Thread.Sleep(10);

            _randomNum = generator.Next(12) + 1;

            isLarger = diceCup.isTotalValueLargerThan(_randomNum);

            Console.WriteLine("The dices rolled: {0}", totalValue);
            Console.WriteLine("Is the value larger than {0}: {1}",_randomNum, isLarger);


            // The LAST line of code should be ABOVE this line
        }
    }
}
