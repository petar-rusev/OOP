using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estates
{
    public class Garage : Estate,IGarage
    {
        private int width;
        private int height;
        public Garage(string Name, EstateType Type, double Area, string Location,bool IsFurnished, int width, int height)
            : base(Name,EstateType.Garage, Area, Location, IsFurnished)
        {
            this.Width=width;
            this.Height = height;
        }
        public Garage(EstateType type)
            : base(type)
        {

        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width=value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height=value;
            }
        }
        public override string ToString()
        {
            return base.ToString()+string.Format("Width: {0}, Height: {1}",this.Width,this.Height);
        }
    }
}
