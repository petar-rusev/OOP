using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
    public class Individual : Customer
    {
        public Individual(string Name)
            : base(Name)
        {
            this.Name = Name;
        }
    }
}
