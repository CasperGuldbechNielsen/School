using System;
using System.Threading;

namespace Sandbox
{
    // This class is for generation of random numbers within a given interval
    class NumberGenerator
    {
        private Random generator;

        public NumberGenerator()
        {
            generator = new Random();
        }

        // Returns a random number in the interval between the values of 
        // "min" and "max"
        public int GetRandomNumberInInterval(int min, int max)
        {
            int value = min + generator.Next(max-min);
            return value;
        }
    }
}
