using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
    public interface IWithdraw
    {
        decimal Withdraw(decimal money);
    }
}
