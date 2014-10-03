using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListVersion
{
    class TestVersion
    {
        static void Main(string[] args)
        {
            VersionAttribute verson = new VersionAttribute(33, 45);
            Console.WriteLine(verson);
        }
    }
}
