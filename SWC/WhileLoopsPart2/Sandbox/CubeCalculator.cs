using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class CubeCalculator
    {
        // Reads the users input from the console window
        public String GetUserInput(String helpText)
        {
            Console.Write(helpText + " ");
            String userInput = Console.ReadLine();
            return userInput;
        }

        // Checks if the given string can be converted into an integer
        public bool IsANumber(String userInput)
        {
            try
            {
                Int32.Parse(userInput);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // Converts the given string into an integer
        public int ConvertToNumber(String userInput)
        {
            return Int32.Parse(userInput);
        }

        // Calculates the cube of the given integer
        public int CalculateCube(int value)
        {
            return (value * value * value);
        }
    }
}
