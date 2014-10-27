using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
    public class Company:Customer
    {
        public Company(string Name):base(Name)
        {
            this.Name = Name;
        }
    }
}
