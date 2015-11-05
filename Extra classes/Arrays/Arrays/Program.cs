using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumberArray = new[]
            {
                1,
                2,
                3
            
            };

            for (int i = 0; i < myNumberArray.Length; i++)
            {
                Console.WriteLine(i);
            }

            foreach (int i in myNumberArray)
            {
                Console.WriteLine(i);
            }

            List<int> myList = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
                
            };

            foreach (var i in myList)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 6)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            
            Dictionary<Class1, string> myDict = new Dictionary<Class1, string>();
            myDict[Class1.Name] = "Bob";
            myDict[Class1.PhoneNumber] = "12345678";
            myDict[Class1.Address] = "Brudelysvej 428";

            foreach (var variable in myDict)
            {
                //Console.WriteLine("Found {0} with value {1}", variable.Key, variable.Value);
                switch (variable.Key)
                {
                    case Class1.PhoneNumber:
                        Console.WriteLine("Phone number: \t" + variable.Value);
                        continue;
                    case Class1.Address:
                        Console.WriteLine("Address: \t" + variable.Value);
                        continue;
                    case Class1.Name:
                        Console.WriteLine("Name: \t \t" + variable.Value);
                        continue;
                }
            }

        }
    }
}
