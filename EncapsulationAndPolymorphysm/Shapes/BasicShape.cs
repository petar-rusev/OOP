using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public abstract class BasicShape : Ishape
    {
        private float width;
        private float height;
        private float sideOne;
        private float sideTwo;
        private float sideThree;
        private float radius;
        public BasicShape(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
        public BasicShape(float SideOne, float SideTwo, float SideThree)
        {
            this.SideOne = SideOne;
            this.SideTwo = SideTwo;
            this.sideThree = SideThree;
        }
        public BasicShape(float radius)
        {
            this.Radius = radius;
        }
        public abstract double CalculateArea();


        public abstract double CalculatePerimeter();


        public float SideOne
        {
            get
            {
                return this.sideOne;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid triangle side argument.");
                }
                else
                {
                    this.sideOne = value;
                }
            }
        }
        public float SideTwo
        {
            get
            {
                return this.sideTwo;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid triangle side argument.");
                }
                else
                {
                    this.sideTwo = value;
                }
            }
        }
        public float SideThree
        {
            get
            {
                return this.sideThree;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid triangle side argument.");
                }
                else
                {
                    this.sideThree = value;
                }
            }
        }
        public float Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid circle radius argument.");
                }
                else
                {
                    this.radius = value;
                }
            }
        }
        public float Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid width argument.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public float Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid height argument.");
                }
                else
                {
                    this.height = value;
                }
            }
        }
    }
}
