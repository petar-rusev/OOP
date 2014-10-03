using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace FractionCalculator
{
    public struct Fraction
    {
        public BigInteger numerator;
        public BigInteger denominator;

        public Fraction(BigInteger numerator, BigInteger denominator):this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public BigInteger Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                try
                {
                    this.numerator = BigInteger.Parse(value.ToString());
                    
                }
                catch (FormatException)
                {

                }
                
            }
        }
        public BigInteger Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                try
                {
                    if (value == 0)
                    {
                        throw new ArgumentException("The denominator can not be 0!Please try again.");
                    }
                    this.denominator = BigInteger.Parse(value.ToString());
                }
                catch (FormatException)
                {
                }
            }
        }
        
        public static Fraction operator +(Fraction one, Fraction two)
        {
            BigInteger CommonDenominator=one.denominator*two.denominator;
            BigInteger devisorOne=CommonDenominator/one.denominator;
            BigInteger devisorTwo=CommonDenominator/two.denominator;
            BigInteger MainNumerator=(devisorOne*one.numerator)+(devisorTwo*two.numerator);
            
            Fraction CalculatedFraction=new Fraction(MainNumerator,CommonDenominator);
            return CalculatedFraction;
        }
        public override string ToString()
        {
            Decimal newNumber = (Decimal)this.Numerator / (Decimal)this.Denominator;
            return string.Format("{0}",newNumber);
        }
    }
    class FractionCalculator
    {
        static void Main()
        {
            Fraction testOne = new Fraction(22, 7);
            Fraction testTwo = new Fraction(40, 4);
            Fraction testThr = testOne + testTwo;
            Console.WriteLine(testThr);

        }
    }
}
