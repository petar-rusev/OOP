using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public class TestInterest
    {
        public static void Main()
        {
            
            InterestCalculator simple = new InterestCalculator(2500m, 7.2,15,GetSimpleInterest);
            Console.WriteLine("{0:0.0000}",simple.result);
            InterestCalculator compound = new InterestCalculator(500m,5.6,10,GetCompoundInterest);
            Console.WriteLine("{0:0.0000}",compound.result);
        }

        public static decimal GetSimpleInterest(decimal money, double interest, int years)
        {
            decimal result = money * (decimal)(1 + (interest * years / 100));
            return result;
        }
        public static decimal GetCompoundInterest(decimal money, double interest, int year)
        {
            
            decimal result = money * (decimal)Math.Pow((1+interest/12/100),year*12);
            return result;
        }
    }
     
}
