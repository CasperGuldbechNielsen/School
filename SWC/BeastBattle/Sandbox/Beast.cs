using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This class implements a simple game character
    // 1) The character has a certain number of "hit points"
    // 2) The character can deal damage
    // 3) The character can receive damage, causing the hit points to decrease
    class Beast
    {
        private int currentHitPoints;
        private NumberGenerator generator;
        private BattleLog log;

        // Create a Beast, using references to a random number generator and a battle log
        public Beast(NumberGenerator generator, BattleLog log)
        {
            this.generator = generator;
            this.log = log;
            Reset();
        }

        // Reset the Beast's state to the original state
        public void Reset()
        {
            currentHitPoints = 90;
        }

        // Returns the amount of points a Beast deals in damage.
        // This damage could then be received by another character
        public int DealDamage()
        {
            int damage = generator.GetRandomNumberInInterval(10, 25);
            string message = "Beast dealt " + damage + " damage!";
            log.Save(message);
            return damage;
        }

        // The Beast receives the amount of damage specified in the parameter.
        // The number of hit points will decrease accordingly
        public void ReceiveDamage(int points)
        {
            currentHitPoints = currentHitPoints - points;
            string message = "Beast receives " + points + " damage, and is down to " + currentHitPoints + " hit points";
            log.Save(message);

            if (IsDead())
            {
                log.Save("Beast died!");
            }
        }

        // Checks if the Beast is dead, defined as having 0 or less hit points...
        public bool IsDead()
        {
            return (currentHitPoints <= 0);
        }
    }
}
