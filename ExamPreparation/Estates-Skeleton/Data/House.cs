using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estates
{
    public class House : Estate, IHouse
    {
        private int floors;
         public House(string Name, EstateType Type, double Area, string Location, bool IsFurnished, int floors)
            : base(Name,EstateType.House, Area, Location, IsFurnished)
        {
            this.Floors = floors;
        }
         public House(EstateType type)
             : base(type)
         {

         }
        public int Floors
        {
            get
            {
                return this.floors;
            }
            set
            {
                this.floors=value;
            }
        }
        public override string ToString()
        {
            return base.ToString()+string.Format("Floors: {0}",this.Floors);
        }
    }
}
