using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // A class for very primitive drawing...
    class DrawingTool
    {
        public DrawingTool()
        {
        }

        public void DrawOneStar()
        {
            Console.Write("*");
        }

        public void DrawOneSpace()
        {
            Console.Write(" ");
        }

        public void StartNewLine()
        {
            Console.WriteLine();
        }
    }
}
