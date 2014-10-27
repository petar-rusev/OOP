using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{
    class TestStringDisperser
    {
        static void Main(string[] args)
        {
            StringDisperser first = new StringDisperser("One", "Two", "Three");
            StringDisperser second = (StringDisperser)first.Clone();
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(first.CompareTo(second));
            foreach (char c in first)
            {
                Console.WriteLine(c+" ");
            }
        }
    }
}
