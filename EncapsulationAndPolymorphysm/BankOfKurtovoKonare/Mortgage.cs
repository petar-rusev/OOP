using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal Balance, decimal InterestRate)
            :base(customer,Balance,InterestRate)
        {
            this.Customer = customer;
            this.Balance = Balance;
            this.InterestRate = InterestRate;
        }
        public override decimal CalculateRate(int months)
        {
            if (months <= 6 && this.Customer is Individual)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateRate(months)/2;
            }
            
        }
    }
}
