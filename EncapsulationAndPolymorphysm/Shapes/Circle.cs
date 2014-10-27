using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle :BasicShape,Ishape
    {

        public Circle(float radius)
            : base(radius)
        {
            this.Radius = radius;
        }
        public override double CalculateArea()
        {
            return this.Radius*this.Radius*Math.PI*2;
        }

        public override double CalculatePerimeter()
        {
            return this.Radius * Math.PI * 2;
        }

       
    }
}
