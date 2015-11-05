using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Geometry
    {

        private double lenght, height, radius, angle1, angle2, angle3, angle4;

        private double perimeter, rectArea, circleArea;
        private bool isRectangle;

        public Geometry()
        {
            
        }

        public void Rectangle(double lenght, double height)
        {
            this.lenght = lenght;
            this.height = height;
        }

        public double CalculateRectPerimeter()
        {
            perimeter = lenght*2 + height*2;

            return perimeter;
        }

        public double CalculateRectArea()
        {
            rectArea = lenght*height;

            return rectArea;
        }

        public void Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateCircleArea()
        {
            circleArea = Math.PI*(radius*radius);

            return circleArea;
        }

        public void Polygon(double angle1, double angle2, double angle3, double angle4)
        {
            this.angle1 = angle1;
            this.angle2 = angle2;
            this.angle3 = angle3;
            this.angle4 = angle4;
        }

        public bool IsRectangle()
        {
            if (angle1 == 90 && angle2 == 90 && angle3 == 90 && angle4 == 90)
            {
                isRectangle = true;
            }
            else
            {
                isRectangle = false;
            }

            return isRectangle;
        }

    }
}
