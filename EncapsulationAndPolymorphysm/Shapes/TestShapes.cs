using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class TestShapes
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4, 5);
            EquilateralTriangle triangle = new EquilateralTriangle(3, 3, 3);
            Circle circle = new Circle(4);
            List<BasicShape> figures = new List<BasicShape>();
            figures.Add(rect);
            figures.Add(triangle);
            figures.Add(circle);

            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine("Area: {0}",figures[i].CalculateArea());
                Console.WriteLine("Perimeter: {0}",figures[i].CalculatePerimeter());
            }
        }
    }
}
