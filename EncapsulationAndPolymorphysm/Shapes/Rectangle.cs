using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Rectangle : BasicShape
    {
        public float width;
        public float height;
        
        public Rectangle(float width, float height)
            : base(width, height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }
        public override double CalculatePerimeter()
        {
            return this.Width * this.Height * 2;
        }
    }
}
