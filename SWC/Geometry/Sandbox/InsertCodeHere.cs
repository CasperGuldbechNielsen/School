using System;

namespace Sandbox
{
    class InsertCodeHere
    {

        private double lenght, height, radius, angle1, angle2, angle3, angle4;
        private double returnedRectPerimeter, returnedRectArea, returnedCircleRadius;
        private bool isRectangle;

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Geometry geometry = new Geometry();

            Console.Write("Please specify the lenght of the rectangle: ");
            try
            {
                lenght = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", lenght);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", lenght);
            }

            Console.Write("Please specify the height of the rectangle: ");
            try
            {
                height = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", height);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", height);
            }

            if (lenght is double && lenght != 0)
            {
                if (height is double && height != 0)
                {
                    geometry.Rectangle(lenght, height);

                    returnedRectPerimeter = geometry.CalculateRectPerimeter();
                    returnedRectArea = geometry.CalculateRectArea();

                    Console.WriteLine("The perimeter of the rectangle is: {0} and the area is: {1}", returnedRectPerimeter, returnedRectArea);

                }
                else
                {
                    Console.WriteLine("You didn't specify a number...");
                }
            }
            else
            {
                Console.WriteLine("You didn't specify a number...");
            }

            Console.WriteLine("..................");

            Console.Write("Please specify the radius of the circle: ");
            try
            {
                radius = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", radius);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", radius);
            }

            if (radius is double && radius != 0)
            {
                geometry.Circle(radius);

                returnedCircleRadius = geometry.CalculateCircleArea();

                Console.WriteLine("The area of the circle is: {0}", returnedCircleRadius);

            }

            Console.WriteLine("..................");

            Console.Write("Please specify the first angle of the polygon: ");
            try
            {
                angle1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", angle1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", angle1);
            }

            Console.Write("Please specify the second angle of the polygon: ");
            try
            {
                angle2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", angle2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", angle2);
            }

            Console.Write("Please specify the third angle of the polygon: ");
            try
            {
                angle3 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", angle3);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", angle3);
            }

            Console.Write("Please specify the last angle of the polygon: ");
            try
            {
                angle4 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", angle4);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", angle4);
            }

            if (angle1 is double && angle2 is double && angle3 is double && angle4 is double && angle1 != 0 && angle2 != 0 && angle3 != 0 && angle4 != 0)
            {
                geometry.Polygon(angle1, angle2, angle3, angle4);

                isRectangle = geometry.IsRectangle();

                Console.WriteLine("The polygon is a rectangle: {0}", isRectangle);

            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
