using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estates
{
    public abstract class Estate :IEstate
    {
        private string name;
        private EstateType type;
        private double area;
        private string location;
        private bool isFurnished;
        public Estate(EstateType type)
        {
            this.Type = type;
        }
        public Estate(string Name,EstateType Type,double Area,string Location,bool IsFurnished)
        {
            this.Name = Name;
            this.Type = Type;
            this.Area = Area;
            this.Location = Location;
            this.IsFurnished = IsFurnished;
        }
       
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public EstateType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type=value;
            }
        }

        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area=value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location=value;
            }
        }

        public bool IsFurnished
        {
            get
            {
                return this.isFurnished;
            }
            set
            {
                this.isFurnished=value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}",this.Type,this.Name,this.Area,this.Location,this.IsFurnished==true?"Yes":"No");
        }
    }
}
