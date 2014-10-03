using System;
using System.Text.RegularExpressions;

namespace GalacticGPS
{
    public enum Planet
    {
        Mercury,Venus,Earth,Mars,Jupiter,Saturn,Uranus,Neptun
    }
    public struct Location
    {
        public double latitude;
        public double longitude;
        public Planet planets;
        public Planet Planets
        {
            get
            {
                return this.planets;
            }
            set
            {
                this.planets = value;
            }
        }
        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                
                string pat = @"[0-9.+]";
                Regex reg = new Regex(pat);
                Match match = reg.Match(value.ToString());
                if (match.Success == false)
                {
                    throw new ArgumentException("Invalid coordinate argument.The latitude must be a number in double format!");
                }
                else
                {
                    this.latitude = value;
                }
            }
        }
        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                try
                {
                    this.latitude = double.Parse(value.ToString());
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
       
        public Location(double x, double y,Planet planet):this()
        {
            this.latitude = x;
            this.longitude = y;
            this.planets = planet;
            
        }
        public override string ToString()
        {
            return string.Format("{0},{1} - {2}",this.Latitude,this.Longitude,this.planets);
        }

    }
    class GalacticGPS
    {
        static void Main()
        {
           
            Console.Write("Please enter a Latitude: ");
            double latitude = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter a Longitude: ");
            double longitude = double.Parse(Console.ReadLine());
            Location home = new Location(latitude, longitude, Planet.Saturn);
            Console.WriteLine(home);
           
        }
    }
}
