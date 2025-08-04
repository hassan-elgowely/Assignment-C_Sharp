using System.Numerics;

namespace First_Project
{
    public class Point3D : IComparable , ICloneable
    {
        #region Q1
        /// 1. Define 3D Point Class and the basic Constructors (use chaining in constructors). 
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int _x)
        {
            X = _x;
        }
        public Point3D(int _x, int _y) : this(_x)
        {
            Y = _y;
        }
        public Point3D(int _x, int _y, int _z) : this(_x, _y)
        {
            Z = _z;
        }

        #endregion
        public static bool operator == (Point3D p1 , Point3D p2)
        {
            return p1.X == p2.X && p1.Y ==p2.Y && p1.Z == p2.Z;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y || p1.Z != p2.Z ;
            
        }
        
        
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(object? other)
        {
            Point3D points = (Point3D)other!;
            if (X > points.X)
                return 1;
            else if (X < points.X)
                return -1;
            else if (X == points.X)
            {
                if (Y > points.Y)
                    return 1;
                else if (Y < points.Y)
                    return -1;
                else
                {
                    return 0;
                }
            }
            else
                return 0;
        }

        public static void SortArrByXY(Point3D[]points)
        {
            Array.Sort(points);
        }

        public object Clone()
        {
            return new Point3D(X,Y,Z);
        }
    }
}
