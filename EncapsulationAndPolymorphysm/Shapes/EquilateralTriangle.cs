using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class EquilateralTriangle : BasicShape
    {
        public EquilateralTriangle(float sideOne, float sideTwo, float sideThree)
            :base(sideOne,sideTwo,sideThree)
        {
            this.SideOne = sideOne;
            this.SideTwo = sideTwo;
            this.SideThree = sideThree;
        }
        
        public override double CalculateArea()
        {
            return (Math.Sqrt(3) * this.SideOne * this.SideOne) / 2;
        }
        public override double CalculatePerimeter()
        {
            return 3 * this.SideOne;
        }
    }
}
