using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estates
{
    public class Apartment : Estate,IApartment
    {
        private int rooms;
        private bool hasElevator;

       
        
        public Apartment(string Name,EstateType Type, double Area, string Location, bool IsFurnished, int rooms, bool elevator)
            : base(Name,EstateType.Apartment, Area, Location, IsFurnished)
        {
            this.Rooms = rooms;
            this.HasElevator = elevator;
        }
        public Apartment(EstateType type)
            : base(type)
        {
            
        }
            
        public int Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                this.rooms=value;
            }
        }

        public bool HasElevator
        {
            get
            {
                return this.hasElevator;
            }
            set
            {
                this.hasElevator=value;
            }
        }
        public override string ToString()
        {
            return base.ToString()+string.Format("Rooms: {0}\nElevator: {1}",this.Rooms,this.HasElevator==true?"Yes":"No");
        }
    }

}
