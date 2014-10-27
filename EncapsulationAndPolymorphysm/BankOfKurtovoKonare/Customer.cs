using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
    public abstract class Customer
    {
        private string name;
        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Invalid name argument.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
