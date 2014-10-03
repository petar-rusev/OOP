using System;
using Point3DAndDistanceCalculator.Point;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
namespace Paths.PathFromToFile
{
    public static class Storage
    {
        public static List<Point3D> FileReader(string file)
        {
            List<Point3D>Path=new List<Point3D>();
            StreamReader reader = new StreamReader(file);
            List<String>points=new List<String>();
            using (reader)
            {
                string line=reader.ReadLine();
                string pat = "[0-9.]+";
                Regex reg = new Regex(pat);
                
                while (line != null)
                {
                    
                    string[] separator = {","};
                    string[] words = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    Point3D tempPoint = new Point3D(double.Parse(words[0]), double.Parse(words[1]), double.Parse(words[2]));
                    Path.Add(tempPoint);
                    line = reader.ReadLine();
                    
                }
            }
            return Path;
        }
        public static string  FileWriter(List<Point3D>points,string file)
        {
            StreamWriter writer = new StreamWriter(file);
            using (writer)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    writer.WriteLine(points[i]);
                }
            }
            return "The path is saved in file "+file;
        }
    }
}
