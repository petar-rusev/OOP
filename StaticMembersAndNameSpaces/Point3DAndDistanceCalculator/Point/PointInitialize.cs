using System;

namespace Point3DAndDistanceCalculator.Point
{
    public class PointInitialize
    {
        static void Main()
        {
            Point3D point = new Point3D(-25,2,17);
            Point3D start=Point3D.StartingPoint;
            Console.WriteLine(start.ToString());
            double distance = DistanceCalculator.Calculate(start,point);
            Console.WriteLine(point.ToString());
            Console.WriteLine(distance);
            
        }
    }
}
