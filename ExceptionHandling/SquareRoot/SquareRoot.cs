using System;

namespace SquareRoot
{
    public class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            string num = Console.ReadLine();
            try
            {
                uint number = uint.Parse(num);
                double sqr = Math.Sqrt(number);
                Console.WriteLine(sqr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid Number!");
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
        }
    }
}