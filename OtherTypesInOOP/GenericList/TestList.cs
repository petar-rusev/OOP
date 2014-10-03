using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> s = new GenericList<int>(10);
            s.add(8);
            s.add(5);
            s.add(8);
            s.add(7);


            Console.WriteLine(s.index(1));
            s.remove(0);
            s.insert(1, 4);
            Console.WriteLine(s.index(1));
            s.printing();
            s.Max();
            s.Min();
            s.clear();
        }
    }
}