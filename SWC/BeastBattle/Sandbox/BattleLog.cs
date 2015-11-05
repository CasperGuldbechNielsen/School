using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This class implements a simple logging system, where strings can be collected
    // one by one. The entire set of strings can then be printed.
    class BattleLog
    {
        List<string> log;

        public BattleLog()
        {
            log = new List<string>();
        }

        // Save a single string
        public void Save(string message)
        {
            log.Add(message);
        }

        // Print out all the strings saved in the log
        public void PrintEntireBattleLog()
        {
            Console.WriteLine("Battle log :");
            Console.WriteLine("======================================");
            foreach (string s in log)
            {
                Console.WriteLine(s);
            }
        }

        // Clear out all strings from the log
        public void Reset()
        {
            log.Clear();
        }
    }
}
