using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        public decimal spentmoney;
        public Customer(decimal money,string NameOne,string NameSecond,string ID)
            : base(ID,NameOne,NameSecond)
        {
            this.SpentMoney = money;
        }
        public decimal SpentMoney
        {
            get
            {
                return this.spentmoney;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Customer spent money argument. The spet amount of money must be grater or equal to 0.");
                }
                else
                {
                    this.spentmoney=value;
                }
            }
        }
    }
}
