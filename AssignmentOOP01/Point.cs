using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    internal struct Point
    {
        private double X;
        private double Y;


        public double Vx
        {
            set { X = value; }
            get { return X; }
        }
        public double Vy
        {
            set { Y = value; }
            get { return Y; }
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double Distance(Point other)
        {
            double dx = other.X - this.X;
            double dy = other.Y - this.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

    }
}
