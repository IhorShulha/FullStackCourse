using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Vehicle
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public double Speed { get; set; }
        public double Price { get; set; }
        public double Year { get; set; }


        public void Coordinate(double CoordinateX, double CoordinateY)
        {
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
        }

        public void SpeedMethod(double Speed)
        {
            this.Speed = Speed;
        }
    }
}
