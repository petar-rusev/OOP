using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKurtovoKonare
{
   
    public class Loan:Account
    {
        public Loan(Customer Customer,decimal Balance,decimal InterestRate)
            : base(Customer, Balance, InterestRate)
        {
            this.Customer = Customer;
            this.Balance = Balance;
            this.InterestRate = InterestRate;
        }
        public override decimal CalculateRate(int months)
        {
            if (months <= 3 && this.Customer is Individual)
            {
                return this.Balance;
            }
            else if (months <= 2 && this.Customer is Company)
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
