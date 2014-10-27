using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    class TestBank
    {
        static void Main(string[] args)
        {
            Individual CustOne = new Individual("Maria");
            Deposit CustOneDeposit = new Deposit(CustOne, 10000m, 0.8m);
            CustOneDeposit.Deposit(30);
            Company BadCreatures = new Company("Bad Creatures");
            Deposit BadDeposit = new Deposit(BadCreatures, 350124m, 0.3m);
            BadDeposit.Withdraw(100000);
            BadDeposit = null;
            Console.WriteLine(BadDeposit.CalculateRate(12));
            Console.WriteLine(CustOneDeposit.ToString());
        }
    }
}
