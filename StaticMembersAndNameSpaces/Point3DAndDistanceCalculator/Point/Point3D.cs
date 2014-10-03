using System;
using System.Text.RegularExpressions;

namespace Point3DAndDistanceCalculator.Point
{
    public class Point3D
    {
        private double X;
        private double Y;
        private double Z;
        private static readonly Point3D startingPoint;
        public double PointX
        {
            get
            {
                return this.X;
            }
            set
            {
                string pat = @"[0-9.]";
                Regex reg = new Regex(pat);
                Match match = reg.Match(value.ToString());
                if (match.Success == false)
                {
                    throw new ArgumentException("Invalid X coordinate of a point argument. The X coordinate must be a number!");
                }
                else
                {
                    this.X=value;
                }
            }

        }
        public double PointY
        {
            get
            {
                return this.Y;
            }
            set
            {
                string pat = @"[0-9.]";
                Regex reg = new Regex(pat);
                Match match = reg.Match(value.ToString());
                if (match.Success == false)
                {
                    throw new ArgumentException("Invalid Y coordinate of a point argument. The Y coordinate must be a number!");
                }
                else
                {
                    this.Y=value;
                }
            }
        }
        public double PointZ
        {
            get
            {
                return this.Z;
            }
            set
            {
                string pat = @"[0-9.]";
                Regex reg = new Regex(pat);
                Match match = reg.Match(value.ToString());
                if (match.Success == false)
                {
                    throw new ArgumentException("Invalid Z coordinate of a point argument. The Z coordinate must be a number!");
                }
                else
                {
                    this.Z = value;
                }
            }
        }
        public static Point3D StartingPoint
        {
            get { return Point3D.startingPoint; }
        }
       static Point3D()
       {
           startingPoint = new Point3D(0, 0, 0);
       }
        public Point3D(double x, double y, double z)
        {
            double[] point = { this.PointX = x, this.PointY = y, this.PointZ = z };
            
            
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", this.PointX, this.PointY, this.PointZ);
        }
    }
}
