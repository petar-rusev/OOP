using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BankOfKurtovoKonare
{
    public abstract class Account : IAccount, IDeposit
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        

        public Account(Customer customer, decimal Balance, decimal interest)
        {
            this.InterestRate = interest;
            this.Customer = customer;
            this.Balance = Balance;
        }
        public virtual decimal CalculateRate(int months)
        {
            return this.Balance * (1 + (months * this.InterestRate) / 100);
        }
        public virtual decimal Deposit(decimal Money)
        {
            return this.Balance += Money;
        }
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                string pat = @"[-0-9]+";
                Regex reg = new Regex(pat);
                Match mat = reg.Match(value.ToString());
                if (mat.Success == false)
                {
                    throw new ArgumentException("Invalid Ballance argument.");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (InterestRate < 0)
                {
                    throw new ArgumentException("Invalid interest rate argument.");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Customer Type: {0}\nCustomer Name: {1}\nAccount Balance: {2}\nMounthly based Interest: {3}\n",
                this.Customer.GetType(),this.Customer.Name,this.Balance,this.InterestRate);
        }
    }
}
