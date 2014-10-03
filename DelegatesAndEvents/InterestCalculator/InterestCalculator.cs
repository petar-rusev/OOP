using System;

namespace InterestCalculator
{
    public delegate decimal CalculateInterest(Decimal Money,double interest,int years);
    public class InterestCalculator
    {
        public decimal sum;
        public double interest;
        public int years;
        public decimal result;
               
        public InterestCalculator(Decimal SumMoney, double Interest, int years,CalculateInterest calculation)
        {
            this.Sum = SumMoney;
            this.Interest = Interest;
            this.Years = years;
            result = calculation(this.Sum,this.Interest,this.Years);
            
        }
        public Decimal Sum
        {
            get
            {
                return this.sum;
            }
            set
            {
                try
                {
                    this.sum = Decimal.Parse(value.ToString());
                }
                catch(FormatException)
                {

                }
            }
        }
        public double Interest
        {
            get
            {
                return this.interest;
            }
            set
            {
                try
                {
                    this.interest = double.Parse(value.ToString());
                }
                catch(FormatException)
                {
                }
            }
        }
        public int Years
        {
            get
            {
                return this.years;
            }
            set
            {
                try
                {
                    this.years = int.Parse(value.ToString());
                    if (this.years < 0)
                    {
                        throw new ArgumentException("The years can not be less than 0.");
                    }
                }
                catch(FormatException)
                {
                }
            }
        }
        
    }
}
