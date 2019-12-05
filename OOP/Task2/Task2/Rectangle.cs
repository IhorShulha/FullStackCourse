using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

        public double PerimetrCalculator()
        {
            double p = (side1 + side2) * 2;
            return p;
        }

        public double Area => AreaCalculator();
       
        public double Perimetr => PerimetrCalculator();
    }
}
