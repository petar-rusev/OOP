using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EnterNumbers
{
    class EnterNumbers
    {
        public static int ReadNumber(int start, int end)
        {

            int num = 0;
           
            try
            {
                
                Console.Write("Enter number {0} < your number < {1}: ", start, end);
                num = int.Parse(Console.ReadLine());
               
                if (!(start < num && num < end))
                {

                    while (!(start < num && num < end))
                    {
                        Console.WriteLine("Your number is not in range {0} - {1} !", start, end);
                        Console.Write("Enter number {0} < your number < {1}: ", start, end);
                        num = int.Parse(Console.ReadLine());
                        
                    }
                }
               
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
                        
            return num;
        }
        static void Main()
        {
            int start = 1;
            int end = 100;
            for (int i = 0; i < 10; i++)
            {
                
                start=ReadNumber(start, end);
                
            }
        }
    }
}
