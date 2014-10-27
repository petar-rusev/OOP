using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
    public class Deposit : Account, IWithdraw
    {
        public Deposit(Customer customer,decimal balance,decimal interest)
            : base(customer, balance, interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }
        public decimal Withdraw(decimal money)
        {
            return this.Balance -= money;
        }
        public override decimal CalculateRate(int months)
        {
            if (this.Balance >= 0 && this.Balance <= 1000)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateRate(months);
            }
        }
    }
}
