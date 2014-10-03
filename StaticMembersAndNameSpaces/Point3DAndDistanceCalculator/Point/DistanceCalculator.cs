using System;

namespace Point3DAndDistanceCalculator.Point
{
    public static class DistanceCalculator
    {
        public static double Calculate(Point3D pointOne,Point3D pointTwo)
        {
            double distance = 0;
            double DistOne = Math.Sqrt(Math.Pow((pointOne.PointX - pointTwo.PointX), 2));
            double DistTwo = Math.Sqrt(Math.Pow((pointOne.PointY - pointTwo.PointY), 2));
            double DistThr = Math.Sqrt(Math.Pow((pointOne.PointZ - pointTwo.PointZ), 2));
            distance = DistOne + DistTwo + DistThr;
            return distance;
        }
    }
}
