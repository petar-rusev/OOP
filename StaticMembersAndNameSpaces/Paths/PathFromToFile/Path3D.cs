using Point3DAndDistanceCalculator.Point;
using System;
using System.Collections.Generic;
namespace Paths.PathFromToFile
{
    public class Path3D
    {
        static void Main()
        {
            List<Point3D> test =Storage.FileReader(@"D:\OOP\StaticMembersAndNamespaces\Paths\bin\Debug\input.txt");
            Storage.FileWriter(test,@"D:\OOP\StaticMembersAndNamespaces\Paths\bin\Debug\output.txt");
        }
    }
}
