using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
    public interface IAccount
    {
        Customer Customer
        {
            get;
            set;
        }

        decimal Balance
        {
            get;
            set;
        }

        decimal InterestRate
        {
            get;
            set;
        }
    }
}
