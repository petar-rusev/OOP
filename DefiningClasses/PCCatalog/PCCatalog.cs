using System;
using System.Collections.Generic;
using System.Text;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            string[] lines = System.IO.File.ReadAllLines(@"D:\OOP\DefiningClasses\PCCatalog\input.txt");

            Components component = new Components(lines[2], lines[3],(lines[4]));
            Components componentOne = new Components(lines[5], lines[6],(lines[7]));
            Components componentTwo = new Components(lines[8],lines[9]);
            Components componentThr = new Components(lines[10],lines[11]);
            List<Components> CompParts = new List<Components>();
            CompParts.Add(component);
            CompParts.Add(componentOne);
            CompParts.Add(componentTwo);
            CompParts.Add(componentThr);
            Computer comp = new Computer(lines[0], double.Parse(lines[1]), CompParts);
            List<List<String>>data=Computer.ComponentsData(comp.comps);
            List<String> parts = data[0];
            List<String> price = data[1];
            Computer.Display(comp.Name,comp.CompPrice,parts, price);
        }
    }
}
