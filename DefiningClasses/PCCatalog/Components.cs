using System;
using System.Text.RegularExpressions;

namespace PCCatalog
{
    class Components
    {
        private string name;
        private string details;
        private string price;
        public string ComponentName 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid component name argument.The component name can not be empty string!");
                }
                else
                {
                    this.name=value;
                }
            }
        }
        public string CompDetails
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value.Length > 5 && value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid component details argument.The component details can not be less than 5 characters,null or empty!");
                }
                else
                {
                    this.details=value;
                }
            }
        }
        public string ComponentPrice
        {
            get
            {
                return this.price;
            }
            set
            {
                string pat = @"[0-9]+";
                Regex reg = new Regex(pat);
                Match match = reg.Match(value);
                if (match.Success == true)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Invalid component price argument. The component price must be a number!");
                }
            }
        }
        public Components(string Name, string Details, string Price)
        {
            this.ComponentName = Name;
            this.CompDetails = Details;
            this.ComponentPrice = Price;
        }
        public Components(string Name, string Price)
         
        {
            this.ComponentName = Name;
            this.ComponentPrice = Price;
        }
    }
}
