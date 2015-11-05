using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            DrawingTool drawer = new DrawingTool();


            // YOUR JOB: Add code to draw shapes

            for (int i = 0; i < 10; i++)
            {
                drawer.DrawOneStar();
            }
            
            drawer.StartNewLine();

            for (int i = 0; i < 5; i++)
            {
                drawer.DrawOneStar();
                drawer.DrawOneSpace();
            
            }

            drawer.StartNewLine();

            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    drawer.DrawOneStar();
                }
                drawer.StartNewLine();
            }

            drawer.StartNewLine();
            drawer.StartNewLine();

            for (int i = 0; i < 10; i++)
            {
                for (int b = 0; b <= i; b++)
                {
                    drawer.DrawOneStar();
                }
                drawer.StartNewLine();
            }

            drawer.StartNewLine();
            drawer.StartNewLine();

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if ((x == y) || (x + y == 9))
                    {
                        drawer.DrawOneStar();
                    }
                    else
                    {
                        drawer.DrawOneSpace();
                    }
                }
                drawer.StartNewLine();
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
