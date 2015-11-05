using System;

namespace Dice_Game
{
    public class DiceGame
    {
        private Die d1;
        private Die d2;
        static Random r = new Random();
        private int faceValue_d1;
        private int faceValue_d2;
        private int result;
        // instance variables - replace the example below with your own

        public DiceGame()
        {
            d1 = new Die(r);
            d2 = new Die(r);
        }

        public void play()
        {
            d1.roll();
            d2.roll();
            faceValue_d1 = d1.getFaceValue();
            faceValue_d2 = d2.getFaceValue();
            result = faceValue_d1 + faceValue_d2;
            
        }

        public int DiceRollOne()
        {
            return faceValue_d1;
        }

        public int DiceRollTwo()
        {
            return faceValue_d2;
        }

    }
}