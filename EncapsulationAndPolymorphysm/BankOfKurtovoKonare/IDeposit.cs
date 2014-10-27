using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
    public interface IDeposit
    {
        decimal Deposit(decimal money);
    }
}
