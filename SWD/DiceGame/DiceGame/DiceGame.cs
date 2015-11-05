using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class DiceGame
    {
        private Die d1;
        private Die d2;
        static Random r = new Random();
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
            int faceValue_d1 = d1.getFaceValue();
            int faceValue_d2 = d2.getFaceValue();
            int result = faceValue_d1 + faceValue_d2;
            Console.WriteLine("Result " + result);
            if (result == 7)
                Console.WriteLine("You win, congratulation");
            else
                Console.WriteLine("You loose, try again");

        }

    }

}
